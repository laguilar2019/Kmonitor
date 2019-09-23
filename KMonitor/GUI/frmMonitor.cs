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
using System.Xml.Linq;

namespace KMonitor.GUI
{
    public partial class frmMonitor : Form
    {
        public DBM.CLS.Metodos.myButton[] boton2Mesas;
        int OrderIdPendiente,LastOrderIdClicked;
        List<int> pedidosEnProceso = new List<int>();
        List<int> pedidosFinalizados = new List<int>();
        DBM.CLS.QUERY QueryTable = new DBM.CLS.QUERY();
        frmDetallePedido frmDetalle = new frmDetallePedido();
        public frmMonitor()
        {
            InitializeComponent();
        }
        private void frmMonitor2_Load(object sender, EventArgs e)
        {
            cargarEntrada();
            OrderIdPendiente = 0;
            frmDetalle.TopLevel = false;
            flowPanelFinalizado.Controls.Add(frmDetalle);
            Temporizador.Start();
            timerCambios.Start();
            timerVisibilidadporCategorias.Start();
        }
        private void cargarEntrada()
        {
            DBM.CLS.QUERY Tabla = new DBM.CLS.QUERY();
            DataTable DT = Tabla.GetRecordsFilters("Pedido","cancelado","=","0");
            int i = 0;
            foreach (DataRow dr in DT.Rows)
            {
                int esta = Byte.Parse(dr["listo"].ToString());
                ///////////////Prueba
                bool btnnuevo = true;
                foreach (Control item in flowPanelPendiente.Controls)
                {
                    if (item.Name == dr["idPedido"].ToString())
                    {
                        btnnuevo = false;
                        break;
                    }
                }
                foreach (Control item in flowPanelProceso.Controls)
                {
                    if (item.Name == dr["idPedido"].ToString())
                    {
                        btnnuevo = false;
                        break;
                    }
                }
                foreach (Control item in flowPanelFinalizado.Controls)
                {
                    if (item.Name == dr["idPedido"].ToString())
                    {
                        btnnuevo = false;
                        break;
                    }
                }
                /////////////// 17-08-2019
                if (btnnuevo) {
                    int MaxIdeDetalle = Tabla.MaximoValor("idDetalle", "pedido_detalle", "idPedido", dr["idPedido"].ToString());
                    creaBotonEntrar(int.Parse(dr["idPedido"].ToString()), dr["total"].ToString(), MaxIdeDetalle, esta);
                }
                i++;
            }
        }

        private int GetOrndenPedidoPendiente1()
        {
            int resultado = 0;
            foreach (Button btn in flowPanelPendiente.Controls)
            {
                resultado = int.Parse(btn.Name);
                if (resultado > 0)
                    break;

            }
            return resultado;
        }
        private int GetOrndenPedidoPendiente2()
        {
            int resultado = 0;
            DBM.CLS.QUERY Tabla = new DBM.CLS.QUERY();
            DataTable DT = Tabla.GetRecordsFilters("Pedido","listo","0");
            foreach (DataRow dr in DT.Rows)
            {
                resultado = int.Parse(dr["idPedido"].ToString());
                break;
            }
            return resultado;
        }
        void creaBotonEntrar(int pedidoID, String total,int lastIdDetalle, int estado)
        {
            DBM.CLS.Metodos.myButton boton = new DBM.CLS.Metodos.myButton();
            boton.indice = pedidoID;
            boton.Name = pedidoID.ToString();//TRAE EL ID DEL SALON QUE SIRVE COMO FILTRO
            boton.campo1 = pedidoID.ToString();
            boton.campo2 = total;
            boton.campo3 = lastIdDetalle.ToString();
            boton.Tag = estado.ToString(); //Guardamos el estado en el tag por si desea modificarse, por el momento no se usa
            boton.Text = "Orden # " + pedidoID.ToString();
            boton.AutoSize = false;
            boton.AllowDrop= true;
            boton.Width = Properties.Settings.Default.sizeButtonPedido.Width;
            boton.Height = Properties.Settings.Default.sizeButtonPedido.Height;
            boton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 1;
            boton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            MyToolTip.SetToolTip(boton, "\nPedido: " +boton.campo1  + "\nTotal: " + boton.campo2 + "\nLastIdDetalle: " + boton.campo3);
            boton.Click_ConIndice += Boton_Click_ConIndice;// para el evento click de cada boton creado

            if (filtrarPedidoconCategoriasDisponibles(int.Parse(boton.campo1)) <= 0)
                boton.Visible = false;

            if (estado == 0)
                flowPanelPendiente.Controls.Add(boton);// añadimos los botones al contenedor
            else if(estado == 1)
                flowPanelProceso.Controls.Add(boton);// añadimos los botones al contenedor
            else if(estado==2)
                flowPanelFinalizado.Controls.Add(boton);// añadimos los botones al contenedor
        }

        void Boton_Click_ConIndice(object sender, DBM.CLS.Metodos.IntEventArgs e)
        {
            frmDetalle.Show();
            frmDetalle.OrderID = e.indice;
            frmDetalle.cambiosDetectados = false;
            frmDetalle.UltimoIDDetalle = Convert.ToInt32(e.campo3);
            frmDetalle.lblObservaciones.Text = "Último idDetalle:" + frmDetalle.UltimoIDDetalle;
            frmDetalle.filtrarPedido(e.indice);

            LastOrderIdClicked = e.indice;//Esta variable conserva el ultimo idPedido al que se le ha dado click.
            DataRow drOrder = QueryTable.GetUniqueRecord("Pedido", "idPedido", e.campo1);

            if (((Button)sender).BackColor != Color.Orange)
            {
                if (((Button)sender).BackColor == System.Drawing.SystemColors.ControlLightLight)
                {
                    //EN ESTOS PANELES NO ACEPTAN SELECCIÓN MULTIPLE
                    flowPanelPendiente.Controls.OfType<Button>().ToList().ForEach(o => o.BackColor = System.Drawing.SystemColors.ControlLightLight);
                    flowPanelFinalizado.Controls.OfType<Button>().ToList().ForEach(o => o.BackColor = System.Drawing.SystemColors.ControlLightLight);

                    ((Button)sender).BackColor = System.Drawing.SystemColors.ActiveCaption;
                    if (((Button)sender).Tag.ToString() == "0")
                        OrderIdPendiente = e.indice;
                    if (((Button)sender).Tag.ToString() == "1")
                        pedidosEnProceso.Add(e.indice);
                    //EN ESTOS PANELES NO ACEPTAN SELECCIÓN MULTIPLE
                    //if (drOrder["listo"].ToString() == "2")
                        //pedidosFinalizados.Add(e.indice);
                }
                else
                {
                    ((Button)sender).BackColor = System.Drawing.SystemColors.ControlLightLight;
                    if (((Button)sender).Tag.ToString() == "0")
                        OrderIdPendiente = GetOrndenPedidoPendiente1();
                    if (((Button)sender).Tag.ToString() == "1")
                        pedidosEnProceso.Remove(e.indice);
                }
            }
            else
            {
                //ACTUALIZAR LOS CAMBIOS EN LA COMANDA
                DataTable DT = new DataTable();
                DT = QueryTable.GetRecordsFilters("pedido_detalle", "idPedido", drOrder["idPedido"].ToString());
                int totalReg = DT.Rows.Count;
                if (e.campo2 != drOrder["total"].ToString() || int.Parse(e.campo3) < int.Parse(DT.Rows[totalReg - 1]["idDetalle"].ToString()))
                {
                    frmDetalle.cambiosDetectados = true;
                    frmDetalle.OrderID = e.indice;
                    frmDetalle.UltimoIDDetalle = int.Parse(e.campo3);
                    frmDetalle.lblObservaciones.Text = "Último idDetalle:" + frmDetalle.UltimoIDDetalle;
                    frmDetalle.filtrarPedido(e.indice);

                    foreach (DBM.CLS.Metodos.myButton item in flowPanelProceso.Controls)
                    {
                        if (item.Name == e.indice.ToString())
                        {
                            item.campo2 = drOrder["total"].ToString();
                            item.campo3 = DT.Rows[totalReg - 1]["idDetalle"].ToString();
                        }
                    }
                    ((Button)sender).BackColor = System.Drawing.SystemColors.ControlLightLight;
                    try
                    {
                        if (((Button)sender).Tag.ToString() == "1")
                            pedidosEnProceso.Remove(e.indice);
                    }
                    catch { }

                    //AGREGADO EL 09-09-2019 ANTES DE ESTE CAMBIO TODO BIEN
                    foreach (DBM.CLS.Metodos.myButton item in flowPanelFinalizado.Controls.OfType<Button>())
                    {
                        if (item.Name == e.indice.ToString())
                        {
                            item.campo2 = drOrder["total"].ToString();
                            item.campo3 = DT.Rows[totalReg - 1]["idDetalle"].ToString();
                        }
                    }
                }
                //Qué hacer cuando se le de click a un botón naranja
            }
            
        }
        private void btnSendToProcesar_Click(object sender, EventArgs e)
        {
            DBM.CLS.Transaccion Trans = new DBM.CLS.Transaccion();

            if (OrderIdPendiente == 0)
                OrderIdPendiente = GetOrndenPedidoPendiente1();
            string Query = "Update Pedido set listo = 1 where idPedido =" + OrderIdPendiente;

            if (Trans.CreateTransaction(Query))
            {
                foreach (Control item in flowPanelPendiente.Controls)
                {
                    if (item.Name == OrderIdPendiente.ToString())
                    {
                        item.Tag = "1";
                        item.BackColor = System.Drawing.SystemColors.ControlLightLight;
                        flowPanelProceso.Controls.Add(item);
                        flowPanelPendiente.Controls.Remove(item);
                        break; //important step
                    }
                }
                OrderIdPendiente = 0;
            }
        }

        private void btnSendToFinalizar_Click(object sender, EventArgs e)
        {
            pedidosEnProceso.Sort(); //Ordenamos la lista
            DBM.CLS.Transaccion Trans = new DBM.CLS.Transaccion();
            string listaEnProceso = string.Join(",", pedidosEnProceso.ToArray());
            string Query = "Update Pedido set listo = 2 where idPedido In(" + listaEnProceso + ")";
            if (pedidosEnProceso.Count > 0)
            {
                if (Trans.CreateTransaction(Query))
                {
                    foreach (int btnName in pedidosEnProceso)
                    {
                        foreach (Control item in flowPanelProceso.Controls)
                        {
                            if (item.Name == btnName.ToString())
                            {
                                item.Tag = "2";
                                item.BackColor = System.Drawing.SystemColors.ControlLightLight;
                                flowPanelFinalizado.Controls.Add(item);
                                flowPanelProceso.Controls.Remove(item);
                                break; //important step
                            }
                        }
                    }
                    pedidosEnProceso.Clear();
                }
            }
        }

        private void btnSendToPendientes_Click(object sender, EventArgs e)
        {
            pedidosEnProceso.Sort(); //Ordenamos la lista
            DBM.CLS.Transaccion Trans = new DBM.CLS.Transaccion();
            string listaEnProceso = string.Join(",", pedidosEnProceso.ToArray());
            string Query = "Update Pedido set listo = 0 where idPedido In(" + listaEnProceso + ")";
            if (pedidosEnProceso.Count>0) {
                if (Trans.CreateTransaction(Query))
                {
                    foreach (int btnName in pedidosEnProceso)
                    {
                        foreach (Control item in flowPanelProceso.Controls)
                        {
                            if (item.Name == btnName.ToString())
                            {
                                item.Tag = "0";
                                item.BackColor = System.Drawing.SystemColors.ControlLightLight;
                                flowPanelPendiente.Controls.Add(item);
                                flowPanelProceso.Controls.Remove(item);
                                break; //important step
                            }
                        }
                    }
                    pedidosEnProceso.Clear();
                }
            }
        }

        private void btnShowHideFrmDetalle_Click(object sender, EventArgs e)
        {
            //frmDetalle.TopLevel = false;
            //frm.IsMdiChild = true;
            if (btnShowHideFrmDetalle.Tag == "1")
            {
                btnShowHideFrmDetalle.Tag = "2";
                flowPanelFinalizado.Controls.OfType<Button>().ToList().ForEach(o => o.Visible= false);
                //flowPanelFinalizado.Controls.Clear();
                //flowPanelFinalizado.Controls.Add(frmDetalle);
                frmDetalle.Show();
            }
            else
            {
                btnShowHideFrmDetalle.Tag = "1";
                flowPanelFinalizado.Controls.OfType<Button>().ToList().ForEach(o => o.Visible = true);
                //flowPanelFinalizado.Controls.Remove(frmDetalle);
                frmDetalle.Hide();
            }
        }

        private void MenuContextualKMonitor_Click(object sender, EventArgs e)
        {
            GUI.frmSettings frm = new frmSettings();
            frm.ShowDialog();

            flowPanelPendiente.Controls.OfType<Button>().ToList().ForEach(o => o.Width = int.Parse(frm.txtAnchoPedido.Text));
            flowPanelPendiente.Controls.OfType<Button>().ToList().ForEach(o => o.Height = int.Parse(frm.txtAltoPedido.Text));

            flowPanelProceso.Controls.OfType<Button>().ToList().ForEach(o => o.Width = int.Parse(frm.txtAnchoPedido.Text));
            flowPanelProceso.Controls.OfType<Button>().ToList().ForEach(o => o.Height = int.Parse(frm.txtAltoPedido.Text));

            flowPanelFinalizado.Controls.OfType<Button>().ToList().ForEach(o => o.Width = int.Parse(frm.txtAnchoPedido.Text));
            flowPanelFinalizado.Controls.OfType<Button>().ToList().ForEach(o => o.Height = int.Parse(frm.txtAltoPedido.Text));
        }

        private void btnConfiguraciones_Click(object sender, EventArgs e)
        {
            GUI.frmSettings frm = new frmSettings();
            frm.ShowDialog();
            //Cuando se cierra el formulario continua con estas modificaciones
            flowPanelPendiente.Controls.OfType<Button>().ToList().ForEach(o => o.Width = int.Parse(frm.txtAnchoPedido.Text));
            flowPanelPendiente.Controls.OfType<Button>().ToList().ForEach(o => o.Height = int.Parse(frm.txtAltoPedido.Text));

            flowPanelProceso.Controls.OfType<Button>().ToList().ForEach(o => o.Width = int.Parse(frm.txtAnchoPedido.Text));
            flowPanelProceso.Controls.OfType<Button>().ToList().ForEach(o => o.Height = int.Parse(frm.txtAltoPedido.Text));

            flowPanelFinalizado.Controls.OfType<Button>().ToList().ForEach(o => o.Width = int.Parse(frm.txtAnchoPedido.Text));
            flowPanelFinalizado.Controls.OfType<Button>().ToList().ForEach(o => o.Height = int.Parse(frm.txtAltoPedido.Text));
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            cargarEntrada();
            ValidaPedido_NoEliminado();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerCambios_Tick(object sender, EventArgs e)
        {
            ValidaCambiosEnPedido();
            quitarePedidosPagados();
        } 

        private void ContextMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ValidaCambiosEnPedido()
        {
            DBM.CLS.QUERY QueryTable = new DBM.CLS.QUERY();
            DataRow drOrder;
            DataRow drOrderDetalle;
            DBM.CLS.Metodos.myButton boton = new DBM.CLS.Metodos.myButton();
            foreach (DBM.CLS.Metodos.myButton item in flowPanelProceso.Controls)
            {
                drOrder = QueryTable.GetUniqueRecord("Pedido", "idPedido", item.Name);
                if (drOrder!=null) {
                    DataTable DT = new DataTable();
                    DT = QueryTable.GetRecordsFilters("pedido_detalle", "idPedido", drOrder["idPedido"].ToString());
                    int totalReg = DT.Rows.Count;
                    try
                    {
                        if (item.campo2 != drOrder["total"].ToString() || int.Parse(item.campo3) < int.Parse(DT.Rows[totalReg - 1]["idDetalle"].ToString()))
                        {
                            item.BackColor = Color.Orange;
                            if (!item.Enabled)
                            {
                                item.Enabled = true;
                                item.Text.Replace("Cancelada", "");
                            }
                            if (!item.Text.Contains("Hay cambios"))
                                item.Text = item.Text + " Hay cambios";
                            if (LastOrderIdClicked == item.indice)
                            {
                                /*
                                frmDetalle.OrderID = item.indice;
                                frmDetalle.UltimoIDDetalle = Convert.ToInt32(item.campo3);
                                frmDetalle.cambiosDetectados = true;
                                frmDetalle.lblObservaciones.Text = "Último idDetalle:" + frmDetalle.UltimoIDDetalle;
                                frmDetalle.filtrarPedido(item.indice);
                                //Prueba al 18-08-2019 para que no actualice el formulario de pedido_detalle
                                item.campo2 = drOrder["total"].ToString();
                                item.campo3 = DT.Rows[totalReg - 1]["idDetalle"].ToString();
                                */
                            }
                        }
                    }
                    catch { }
                }
            }
            foreach (DBM.CLS.Metodos.myButton item in flowPanelFinalizado.Controls.OfType<Button>())
            {
                drOrder = QueryTable.GetUniqueRecord("Pedido", "idPedido", item.Name);
                DataTable DT = new DataTable();
                DT = QueryTable.GetRecordsFilters("pedido_detalle", "idPedido", drOrder["idPedido"].ToString());
                int totalReg = DT.Rows.Count;
                try
                {
                    if (item.campo2 != drOrder["total"].ToString() || int.Parse(item.campo3) < int.Parse(DT.Rows[totalReg - 1]["idDetalle"].ToString()))
                    {
                        item.BackColor = Color.Orange;
                        if (!item.Text.Contains("Hay cambios"))
                            item.Text = item.Text + " Hay cambios";
                    }
                }
                catch { }
            }
        }
        private void ValidaPedido_NoEliminado()
        {
            DBM.CLS.QUERY QueryTable = new DBM.CLS.QUERY();
            DataRow drOrder;
            foreach (Control item in flowPanelPendiente.Controls)
            {
                if ((drOrder = QueryTable.GetUniqueRecord("Pedido", "idPedido", item.Name)) == null)
                    flowPanelPendiente.Controls.Remove(item);
            }
            foreach (Control item in flowPanelProceso.Controls)
            {
                if ((drOrder = QueryTable.GetUniqueRecord("Pedido", "idPedido", item.Name)) == null)
                {
                    //flowPanelProceso.Controls.Remove(item);
                    item.BackColor = Color.Red;
                    item.Enabled = false;
                    item.Text = item.Text + " Cancelada";

                }

            }
        }
        private void quitarePedidosPagados()
        {
            DBM.CLS.QUERY QueryTable = new DBM.CLS.QUERY();
            DataRow drOrder;
            foreach (DBM.CLS.Metodos.myButton item in flowPanelFinalizado.Controls.OfType<Button>())
            {
                drOrder = QueryTable.GetUniqueRecord("Pedido", "idPedido", item.Name);
                if (drOrder != null)
                {
                    try
                    {
                        if (item.campo1 == drOrder["idPedido"].ToString() && bool.Parse(drOrder["cancelado"].ToString())==true)
                        {
                            flowPanelFinalizado.Controls.Remove(item);
                        }
                    }
                    catch { }
                }
            }
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
        private int filtrarPedidoconCategoriasDisponibles(int OrderId)
        {
            string QueryDetalle="";
            if (LeerXml().Length > 0)
                QueryDetalle = "SELECT pd.idDetalle,pd.idPedido,pd.idProducto,p.nombre as producto,pd.cantidad,pd.cantidadAnterior,pd.precio,pd.subTotal,pd.grupo,pd.idCocinero,pd.extras,DATE_FORMAT(pd.horaPedido, '%Y-%m-%d %H:%i:%s') as horaPedido,DATE_FORMAT(pd.horaEntregado, '%Y-%m-%d %H:%i:%s') as horaEntregado,pe.fecha,m.idMesa,m.nombre as mesa from pedido_detalle pd, producto p, pedido pe  left join mesa m on (pe.idMesa=m.idMesa) where pd.idProducto = p.idProducto and pd.idpedido = pe.idPedido and p.idFamilia in (" + LeerXml() + " ) and pe.idPedido=" + OrderId;
            else
                QueryDetalle = "SELECT pd.idDetalle,pd.idPedido,pd.idProducto,p.nombre as producto,pd.cantidad,pd.cantidadAnterior,pd.precio,pd.subTotal,pd.grupo,pd.idCocinero,pd.extras,DATE_FORMAT(pd.horaPedido, '%Y-%m-%d %H:%i:%s') as horaPedido,DATE_FORMAT(pd.horaEntregado, '%Y-%m-%d %H:%i:%s') as horaEntregado,pe.fecha,m.idMesa,m.nombre as mesa from pedido_detalle pd, producto p, pedido pe  left join mesa m on (pe.idMesa=m.idMesa) where pd.idProducto = p.idProducto and pd.idpedido = pe.idPedido and pe.idPedido=" + OrderId;

            DBM.CLS.QUERY Query = new DBM.CLS.QUERY();
            DBM.CLS.QUERY consultaDetalle = new DBM.CLS.QUERY();
            DataTable DT = new DataTable();

            DT = consultaDetalle.Consultar(QueryDetalle);
            if (DT != null)
                return DT.Rows.Count;
            else
                return 0;
        }

        private void timerVisibilidadporCategorias_Tick(object sender, EventArgs e)
        {
            mostrarPedidoconCategoriasDisponibles();
        }

        private void mostrarPedidoconCategoriasDisponibles()
        {
            try{
                DBM.CLS.QUERY consultaDetalle = new DBM.CLS.QUERY();
                foreach (DBM.CLS.Metodos.myButton item in flowPanelPendiente.Controls.OfType<Button>())
                {
                    string QueryDetalle = "";
                    if (LeerXml().Length > 0)
                        QueryDetalle = "SELECT pd.idDetalle,pd.idPedido,pd.idProducto,p.nombre as producto,pd.cantidad,pd.cantidadAnterior,pd.precio,pd.subTotal,pd.grupo,pd.idCocinero,pd.extras,DATE_FORMAT(pd.horaPedido, '%Y-%m-%d %H:%i:%s') as horaPedido,DATE_FORMAT(pd.horaEntregado, '%Y-%m-%d %H:%i:%s') as horaEntregado,pe.fecha,m.idMesa,m.nombre as mesa from pedido_detalle pd, producto p, pedido pe  left join mesa m on (pe.idMesa=m.idMesa) where pd.idProducto = p.idProducto and pd.idpedido = pe.idPedido and p.idFamilia in (" + LeerXml() + " ) and pe.idPedido=" + item.campo1;
                    else
                        QueryDetalle = "SELECT pd.idDetalle,pd.idPedido,pd.idProducto,p.nombre as producto,pd.cantidad,pd.cantidadAnterior,pd.precio,pd.subTotal,pd.grupo,pd.idCocinero,pd.extras,DATE_FORMAT(pd.horaPedido, '%Y-%m-%d %H:%i:%s') as horaPedido,DATE_FORMAT(pd.horaEntregado, '%Y-%m-%d %H:%i:%s') as horaEntregado,pe.fecha,m.idMesa,m.nombre as mesa from pedido_detalle pd, producto p, pedido pe  left join mesa m on (pe.idMesa=m.idMesa) where pd.idProducto = p.idProducto and pd.idpedido = pe.idPedido and pe.idPedido=" + item.campo1;

                    DataTable DT = new DataTable();
                    DT = consultaDetalle.Consultar(QueryDetalle);
                    if (DT != null && DT.Rows.Count > 0)
                        item.Visible = true;
                    else
                        item.Visible = false;
                }
                foreach (DBM.CLS.Metodos.myButton item in flowPanelProceso.Controls.OfType<Button>())
                {
                    string QueryDetalle = "";
                    if (LeerXml().Length > 0)
                        QueryDetalle = "SELECT pd.idDetalle,pd.idPedido,pd.idProducto,p.nombre as producto,pd.cantidad,pd.cantidadAnterior,pd.precio,pd.subTotal,pd.grupo,pd.idCocinero,pd.extras,DATE_FORMAT(pd.horaPedido, '%Y-%m-%d %H:%i:%s') as horaPedido,DATE_FORMAT(pd.horaEntregado, '%Y-%m-%d %H:%i:%s') as horaEntregado,pe.fecha,m.idMesa,m.nombre as mesa from pedido_detalle pd, producto p, pedido pe  left join mesa m on (pe.idMesa=m.idMesa) where pd.idProducto = p.idProducto and pd.idpedido = pe.idPedido and p.idFamilia in (" + LeerXml() + " ) and pe.idPedido=" + item.campo1;
                    else
                        QueryDetalle = "SELECT pd.idDetalle,pd.idPedido,pd.idProducto,p.nombre as producto,pd.cantidad,pd.cantidadAnterior,pd.precio,pd.subTotal,pd.grupo,pd.idCocinero,pd.extras,DATE_FORMAT(pd.horaPedido, '%Y-%m-%d %H:%i:%s') as horaPedido,DATE_FORMAT(pd.horaEntregado, '%Y-%m-%d %H:%i:%s') as horaEntregado,pe.fecha,m.idMesa,m.nombre as mesa from pedido_detalle pd, producto p, pedido pe  left join mesa m on (pe.idMesa=m.idMesa) where pd.idProducto = p.idProducto and pd.idpedido = pe.idPedido and pe.idPedido=" + item.campo1;

                    DataTable DT = new DataTable();
                    DT = consultaDetalle.Consultar(QueryDetalle);
                    if (DT != null && DT.Rows.Count > 0)
                        item.Visible = true;
                    else
                        item.Visible = false;
                }
                foreach (DBM.CLS.Metodos.myButton item in flowPanelFinalizado.Controls.OfType<Button>())
                {
                    string QueryDetalle = "";
                    if (LeerXml().Length > 0)
                        QueryDetalle = "SELECT pd.idDetalle,pd.idPedido,pd.idProducto,p.nombre as producto,pd.cantidad,pd.cantidadAnterior,pd.precio,pd.subTotal,pd.grupo,pd.idCocinero,pd.extras,DATE_FORMAT(pd.horaPedido, '%Y-%m-%d %H:%i:%s') as horaPedido,DATE_FORMAT(pd.horaEntregado, '%Y-%m-%d %H:%i:%s') as horaEntregado,pe.fecha,m.idMesa,m.nombre as mesa from pedido_detalle pd, producto p, pedido pe  left join mesa m on (pe.idMesa=m.idMesa) where pd.idProducto = p.idProducto and pd.idpedido = pe.idPedido and p.idFamilia in (" + LeerXml() + " ) and pe.idPedido=" + item.campo1;
                    else
                        QueryDetalle = "SELECT pd.idDetalle,pd.idPedido,pd.idProducto,p.nombre as producto,pd.cantidad,pd.cantidadAnterior,pd.precio,pd.subTotal,pd.grupo,pd.idCocinero,pd.extras,DATE_FORMAT(pd.horaPedido, '%Y-%m-%d %H:%i:%s') as horaPedido,DATE_FORMAT(pd.horaEntregado, '%Y-%m-%d %H:%i:%s') as horaEntregado,pe.fecha,m.idMesa,m.nombre as mesa from pedido_detalle pd, producto p, pedido pe  left join mesa m on (pe.idMesa=m.idMesa) where pd.idProducto = p.idProducto and pd.idpedido = pe.idPedido and pe.idPedido=" + item.campo1;

                    DataTable DT = new DataTable();
                    DT = consultaDetalle.Consultar(QueryDetalle);
                    if (DT != null && DT.Rows.Count > 0)
                        item.Visible = true;
                    else
                        item.Visible = false;
                }
            }
            catch
            {

            } 
        }


    }
}
