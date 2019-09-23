using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
//using System.Configuration.Install;

namespace DBM.GUI
{
    public partial class frmCNX : Form
    {     
        public frmCNX()
        {
            InitializeComponent();
        }

        private void frmCNX_Load(object sender, EventArgs e)
        {

        }

        private void btnObtieneCNX_Click(object sender, EventArgs e)
        {
            CLS.Utilities objCnx = new CLS.Utilities();
            txtCadenaConexion.Text= objCnx.GetConnectionString();
        }

        private void btnProtegeCNX_Click(object sender, EventArgs e)
        {
            if (txtCadenaConexion.TextLength > 0)
            {
                CLS.Utilities objCnx = new CLS.Utilities();
                objCnx.ProtectConnectionString();
            }
            /*
            try
            {
                //Se abre el app.config para recuperar la seccion ConnectionStrings
                Configuration MiAppConfig = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                //Se recupera la seccion ConnectionStrings
                ConnectionStringsSection MiSeccion = (ConnectionStringsSection)(MiAppConfig.GetSection("connectionStrings"));
                //Se protege la seccion, caso contrario se desprotege
                if (MiSeccion.SectionInformation.IsProtected)
                    MiSeccion.SectionInformation.UnprotectSection();
                else
                    MiSeccion.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                //Se guarda los cambios
                MiAppConfig.Save();
                if (MiSeccion.SectionInformation.IsProtected)
                    MessageBox.Show("Cadena de Conexion Protegida");
                else
                    MessageBox.Show("No esta protegida");
              
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }             
                */
        }

        private void btnCambiaCNX_Click(object sender, EventArgs e)
        {
            if (txtCadenaConexion.TextLength > 0)
            {
                CLS.Utilities objCnx = new CLS.Utilities();
                objCnx.SaveConnectionString(txtCadenaConexion.Text);
            }
        }

        private void btnDesProtegeCNX_Click(object sender, EventArgs e)
        {
            if (txtCadenaConexion.TextLength > 0)
            {
                CLS.Utilities objCnx = new CLS.Utilities();
                objCnx.UnprotectConnectionString();
            }
        }
    }
}
