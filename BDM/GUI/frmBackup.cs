using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace DBM.GUI
{
    public partial class frmBackup : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlBackup mb;
        Timer timer1,timer2;
        BackgroundWorker bwImport,bwExport;

        string currentTableName = "";



        int curBytes,curTable=0;
        int totalBytes,totalTables=0;
        bool cancel = false;
        string dumpFile = "C:\\backup.zip";

        public frmBackup()
        {
            InitializeComponent();
            mb = new MySqlBackup();
            mb.ImportProgressChanged += mb_ImportProgressChanged;
            mb.ExportProgressChanged += mb_ExportProgressChanged;

            //Timer Para Importar
            timer1 = new Timer();
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;

            //Timer para exportar
            timer2 = new Timer();
            timer2.Interval = 50;
            timer2.Tick += timer2_Tick;

            bwImport = new BackgroundWorker();
            bwImport.DoWork += bwImport_DoWork;
            bwImport.RunWorkerCompleted += bwImport_RunWorkerCompleted;

            bwExport = new BackgroundWorker();
            bwExport.DoWork += bwExport_DoWork;
            bwExport.RunWorkerCompleted += bwExport_RunWorkerCompleted;
        }
        //METODOS PARA IMPORTAR
        void bwImport_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                mb.ImportFromFile(dumpFile);
            }
            catch (Exception ex)
            {
                cancel = true;
                CloseConnection();
                MessageBox.Show(ex.ToString());
            }
        }

        void mb_ImportProgressChanged(object sender, ImportProgressArgs e)
        {
            if (cancel)
                mb.StopAllProcess();

            totalBytes = (int)e.TotalBytes;
            curBytes = (int)e.CurrentBytes;
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            if (cancel)
            {
                timer1.Stop();
                return;
            }

            progressBar1.Maximum = totalBytes;

            if (curBytes < progressBar1.Maximum)
                progressBar1.Value = curBytes;
            
            lbStatus.Text = "Bytes: " + curBytes + " of " + totalBytes;
        }

        void bwImport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            CloseConnection();
            if (cancel)
            {
                MessageBox.Show("Operación cancelada por el usuario.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else
            {
                if (mb.LastError == null)
                {
                    progressBar1.Value = progressBar1.Maximum;
                    this.Refresh();

                    MessageBox.Show("Restauración de BD ha finalizado exitosamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Restauración de BD ha finalizado con error(es)." + Environment.NewLine + Environment.NewLine + mb.LastError.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            timer1.Stop();
        }
        //METODOS PARA EXPORTAR
        void bwExport_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                mb.ExportToFile(dumpFile);
            }
            catch (Exception ex)
            {
                cancel = true;
                CloseConnection();
                MessageBox.Show(ex.ToString());
            }
        }
        void mb_ExportProgressChanged(object sender, ExportProgressArgs e)
        {
            if (cancel)
            {
                mb.StopAllProcess();
                return;
            }

            totalTables = e.TotalTables;
            curTable = e.CurrentTableIndex;           
            currentTableName = e.CurrentTableName;

        }
        void timer2_Tick(object sender, EventArgs e)
        {
            if (cancel)
            {
                timer2.Stop();
                return;
            }

            progressBar1.Maximum = totalTables;
            if (curTable <= progressBar1.Maximum)
                progressBar1.Value = curTable;

            lbStatus.Text = "Tabla: " + curTable + " of " + totalTables;
        }
        void bwExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            CloseConnection();
            if (cancel)
            {
                MessageBox.Show("Operación cancelada por el usuario.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (mb.LastError == null)
                {
                    progressBar1.Value = progressBar1.Maximum;
                    this.Refresh();

                    MessageBox.Show("Restauración de BD ha finalizado exitosamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Restauración de BD ha finalizado con error(es)." + Environment.NewLine + Environment.NewLine + mb.LastError.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            timer2.Stop();
        }
            void CloseConnection()
        {
            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
            }

            if (cmd != null)
                cmd.Dispose();
        }
        private void btnBackup_Click(object sender, EventArgs e)
        {
            //Sin Usarse porque estan por separados los módulos de respaldo y restauración.
            DateTime Hoy = DateTime.Now; //antes DateTime Hoy = DateTime.today;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "SQL Script|*.sql";
            saveFileDialog1.Title = "Save as Script File";
            DBM.CLS.Utilities config = new CLS.Utilities();
            
            saveFileDialog1.FileName = config.GetMySQL_DatabaseName() + " Date "+ Hoy.ToString("dd-MM-yyyy HH.mm") + ".sql";

            CLS.Utilities objConx = new CLS.Utilities();
            string ConnectionString = objConx.GetConnectionString();
            ConnectionString += ";charset=utf8;convertzerodatetime=true;";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dumpFile = saveFileDialog1.FileName;
                // Reset variables
                curTable = 0;
                totalTables = 0;
                cancel = false;
                // Initialize MySqlConnection and MySqlCommand components
                conn = new MySqlConnection(ConnectionString);
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                conn.Open();
                // Start the Timer here
                timer2.Start();
                mb.ExportInfo.IntervalForProgressReport = (int)nmImInterval.Value;
                mb.Command = cmd;
                bwExport.RunWorkerAsync();

            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            CLS.Utilities objConx = new CLS.Utilities();
            string ConnectionString = objConx.GetConnectionString();
            ConnectionString += ";convertzerodatetime=true;";

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "SQL Script|*.sql";
            openFileDialog1.Title = "Open Script File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dumpFile = openFileDialog1.FileName;

                // Reset variables
                curBytes = 0;
                totalBytes = 0;
                cancel = false;
                // Initialize MySqlConnection and MySqlCommand components
                conn = new MySqlConnection(ConnectionString);
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                conn.Open();
                // Start the Timer here
                timer1.Start();
                mb.ImportInfo.IntervalForProgressReport = (int)nmImInterval.Value;
                mb.Command = cmd;
                bwImport.RunWorkerAsync();
            }
                    
                
            
        }
        private void frmBackup_Load(object sender, EventArgs e)
        {
            
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void btnLimpiarBD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Herramienta en construcción, disculpe las molestias. ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
