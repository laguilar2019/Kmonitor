using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace KMonitor.GUI
{
    public partial class frmDetallePedido : Form
    {
        public bool Activo, cambiosDetectados;
        public int OrderID = 0,UltimoIDDetalle=0;
        string QueryDetalle = "";
        public frmDetallePedido()
        {
            InitializeComponent();
        }

        private void frmDetallePedido_Load(object sender, EventArgs e)
        {
            filtrarPedido(OrderID);
            this.Location = Properties.Settings.Default.PositionFormDetalle;
            this.Size= Properties.Settings.Default.SizeFormDetalle;
            Activo = true;
            LeerXml();
        }
        public void filtrarPedido(int OrderId)
        {
            if(LeerXml().Length>0)
                QueryDetalle = "SELECT pd.idDetalle,pd.idPedido,pd.idProducto,p.nombre as producto,pd.cantidad,pd.cantidadAnterior,pd.precio,pd.subTotal,pd.grupo,pd.idCocinero,pd.extras,DATE_FORMAT(pd.horaPedido, '%Y-%m-%d %H:%i:%s') as horaPedido,DATE_FORMAT(pd.horaEntregado, '%Y-%m-%d %H:%i:%s') as horaEntregado,pe.fecha,m.idMesa,m.nombre as mesa from pedido_detalle pd, producto p, pedido pe  left join mesa m on (pe.idMesa=m.idMesa) where pd.idProducto = p.idProducto and pd.idpedido = pe.idPedido and p.idFamilia in (" + LeerXml() +" ) and pe.idPedido=" + OrderId;
            else
                QueryDetalle = "SELECT pd.idDetalle,pd.idPedido,pd.idProducto,p.nombre as producto,pd.cantidad,pd.cantidadAnterior,pd.precio,pd.subTotal,pd.grupo,pd.idCocinero,pd.extras,DATE_FORMAT(pd.horaPedido, '%Y-%m-%d %H:%i:%s') as horaPedido,DATE_FORMAT(pd.horaEntregado, '%Y-%m-%d %H:%i:%s') as horaEntregado,pe.fecha,m.idMesa,m.nombre as mesa from pedido_detalle pd, producto p, pedido pe  left join mesa m on (pe.idMesa=m.idMesa) where pd.idProducto = p.idProducto and pd.idpedido = pe.idPedido and pe.idPedido=" + OrderId;


            DBM.CLS.QUERY Query = new DBM.CLS.QUERY();
            DBM.CLS.QUERY consultaDetalle = new DBM.CLS.QUERY();
            dgPedido.AutoGenerateColumns = false;
            DataTable DT = new DataTable();
            DT = consultaDetalle.Consultar(QueryDetalle);
            dgPedido.DataSource = DT;
            dgPedido.Columns["cantidadAnterior"].Visible = false;
            if (cambiosDetectados)
            {
                foreach (DataGridViewRow dr in dgPedido.Rows)
                {
                    if (Convert.ToInt32(dr.Cells["idDetalle"].Value.ToString()) > UltimoIDDetalle)
                        dr.DefaultCellStyle.BackColor = Color.Orange;
                    if (Convert.ToInt32(dr.Cells["cantidadAnterior"].Value.ToString()) != 0)
                    {

                        if (Convert.ToInt32(dr.Cells["cantidad"].Value.ToString()) > Convert.ToInt32(dr.Cells["cantidadAnterior"].Value.ToString()))
                            dr.DefaultCellStyle.BackColor = Color.LawnGreen;
                        if (Convert.ToInt32(dr.Cells["cantidad"].Value.ToString()) < Convert.ToInt32(dr.Cells["cantidadAnterior"].Value.ToString()))
                            dr.DefaultCellStyle.BackColor = Color.Red;

                        dgPedido.Columns["cantidadAnterior"].Visible = true;
                    }
                }
                
                cambiosDetectados = false;
            }

            DataRow drPedido = Query.GetUniqueRecord("Pedido","idPedido",OrderId.ToString());
            lblTicket.Text = OrderId.ToString();
            try
            {
                lblMesa.Text = DT.Rows[0]["mesa"].ToString();
            }
            catch{ }
            //Para mostrar el nombre del cliente y del camamero
            try
            {
                DataRow drC = Query.GetUniqueRecord("Cliente", "idCliente", drPedido["idCliente"].ToString());
                if (drC != null && drC.ItemArray.Count() > 0)
                    lblCliente.Text = drC["nombre"].ToString();
                else
                    lblCliente.Text = "";
                //Para mostrar el nombre del camarero
                String _idMesero = drPedido["idMesero"].ToString();
                if (_idMesero.Length > 0)
                {
                    DataRow drMesero = Query.GetUniqueRecord("Empleado", "idEmpleado", _idMesero);
                    lblMesero.Text = drMesero["nombres"].ToString() + " " + drMesero["apellidos"].ToString();
                }
                else
                    lblMesero.Text = "";
            }
            catch (Exception)
            {

            }
            //Para mostrar el nombre del salon          
            try
            {
                Query.showErrorSQL = false;
                string sql = "SELECT nombre FROM salon WHERE idSalon =(SELECT idSalon from mesa where idMesa= "+ drPedido["idMesa"].ToString() + ")";
                DataRow drC = Query.Consultar(sql).Rows[0];
                if (drC != null && drC.ItemArray.Count() > 0)
                    lblMesa.Text = lblMesa.Text +" - "+  drC["nombre"].ToString();
            }
            catch
            {
            }
            Query.showErrorSQL = true;
        }

        private void frmDetallePedido_LocationChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PositionFormDetalle = this.Location;
            Properties.Settings.Default.Save();
        }

        private void frmDetallePedido_SizeChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SizeFormDetalle= this.Size;
            Properties.Settings.Default.Save();
        }

        private void dgPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void frmDetallePedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            Activo = false;
            
        }
        private string LeerXml()
        {
            string archivo = Application.StartupPath + "\\xml\\archivo.xml";
            string result = "";
            XmlDocument doc = new XmlDocument();
            if (System.IO.File.Exists(archivo))
            {
                doc.Load(archivo);
                XmlNodeList listaFamilia = doc.SelectNodes("Categorías/Categoría");
                XmlNode unaFamilia;
                List<string> arreglo = new List<string>();

                for (int i = 0; i < listaFamilia.Count; i++)
                {
                    unaFamilia = listaFamilia.Item(i);
                    string idFamilia = unaFamilia.SelectSingleNode("idFamilia").InnerText;
                    string familia = unaFamilia.SelectSingleNode("familia").InnerText;
                    string mostrar = unaFamilia.SelectSingleNode("enMonitor").InnerText;
                    if (mostrar == "1")
                        arreglo.Add(idFamilia);
                }
                result = string.Join(",", arreglo.ToArray());
            }
            return result;
        }
    }
}
