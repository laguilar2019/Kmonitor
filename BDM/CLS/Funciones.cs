using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data;

namespace DBM.CLS
{
    public class Funciones
    {
        public static void FillCombobox(ComboBox cbo, string TableName, string ValueMember, string DisplayMember)
        {
            QUERY Tabla = new  QUERY();
            cbo.DataSource = Tabla.GetRecords(TableName);
            cbo.DisplayMember = DisplayMember;
            cbo.ValueMember = ValueMember;
        }
        public static void FillCombobox(DataGridViewComboBoxColumn  cbo, string TableName, string ValueMember, string DisplayMember)
        {
            QUERY Tabla = new QUERY();
            cbo.DataSource = Tabla.GetRecords(TableName);
            cbo.DisplayMember = DisplayMember;
            cbo.ValueMember = ValueMember;
            cbo.DataPropertyName = ValueMember;
        }

        public static void FillCombobox(DataGridViewComboBoxCell cbo, string TableName, string ValueMember, string DisplayMember)
        {
            QUERY Tabla = new QUERY();
            cbo.DataSource = Tabla.GetRecords(TableName);
            cbo.DisplayMember = DisplayMember;
            cbo.ValueMember = ValueMember;
        }

        public static void FillGridView(DataGridView  gv, string TableName)
        {
            QUERY Tabla = new QUERY();
            gv.AutoGenerateColumns = false;
            gv.DataSource = Tabla.GetRecords(TableName);            
        }
        public static void FillGridView(DataGridView gv, string TableName, bool autoGenColumns)
        {
            QUERY Tabla = new QUERY();
            gv.AutoGenerateColumns = autoGenColumns;
            gv.DataSource = Tabla.GetRecords(TableName);
        }
        public static void FillGridView(DataGridView gv, DataTable myDataTable)
        {
            QUERY Tabla = new QUERY();
            gv.AutoGenerateColumns = false;
            gv.DataSource = myDataTable;
        }
        public static void FillGridView(DataGridView gv, DataTable myDataTable,bool autoGenColumns)
        {
            QUERY Tabla = new QUERY();
            gv.AutoGenerateColumns = autoGenColumns;
            gv.DataSource = myDataTable;
        }

        public static bool soloDigitos(object sender, KeyPressEventArgs e)
        {
            /*
                else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
             */

            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;

            return e.Handled;
        }
        /// <summary>
        /// Método utilizado para validar que una cadena tenga solo decimales y un solo '.' como separador decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="Texto">Texto evaluado donde solo puede haber un '.' como separador decimal</param>
        /// <returns></returns>
        public static bool soloDecimal(object sender, KeyPressEventArgs e, String Texto)
        {
            string SeparadorDecimal = CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else if (e.KeyChar == Convert.ToChar(SeparadorDecimal) && Texto.IndexOf(Convert.ToChar(SeparadorDecimal)) != -1)
                e.Handled = true;
            else if (e.KeyChar == Convert.ToChar(SeparadorDecimal))
                e.Handled = false;
            else
                e.Handled = true;

            return e.Handled;
        }
        
        /// <summary>
        /// Valida que la entrada sea un numero secuencial o consecutivo, si es asi, devuelve true
        ///  Para que funcione debe estar enviar una secuencia de digitos (Puede utilizar el método soloDigitos)
        /// </summary>
        /// <param name="cajadeTexto"></param>
        /// <returns></returns>
        public static bool validaConsecutivos(TextBox cajadeTexto)
        {
            Boolean resultado = false;
            try
            {
                int num, numSiguiente, contador = 1;
                for (int i = 0; i < cajadeTexto.TextLength; i++)
                {
                    num = int.Parse(cajadeTexto.Text.Substring( i, 1));
                    if (i + 1 < cajadeTexto.TextLength)
                    {

                        numSiguiente = int.Parse(cajadeTexto.Text.Substring(i + 1, 1));
                        if (numSiguiente == num + 1)
                        {
                            contador++;
                        }
                    }
                }
                if (contador == (cajadeTexto.TextLength))
                    resultado = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Application.ProductName , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }

        /// <summary>
        /// Valida que la entrada sea un numero secuencial o consecutivo, si es asi, devuelve true
        ///  Para que funcione debe estar enviar una secuencia de digitos (Puede utilizar el método soloDigitos)
        /// </summary>
        /// <param name="cajadeTexto"></param>
        /// <returns></returns>
        public static bool validaInversos(TextBox cajadeTexto)
        {
            Boolean resultado = false;
            int num, numSiguiente, contador = 1;
            try
            {
                for (int i = 0; i < cajadeTexto.TextLength; i++)
                {                   
                    num = int.Parse(cajadeTexto.Text.Substring( i, 1));
                    if (i + 1 < cajadeTexto.TextLength)
                    {

                        numSiguiente = int.Parse(cajadeTexto.Text.Substring( i + 1, 1));
                        if (num == numSiguiente + 1)
                        {
                            contador++;
                        }
                    }
                }
                if (contador == (cajadeTexto.TextLength))
                    resultado = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }

        //deshabilitar controles TextBox
        public static void enabledTextBox(Control objeto, bool enable)
        {
            foreach (Control ctl in objeto.Controls)
            {
                if (ctl.GetType() == typeof(System.Windows.Forms.TextBox))
                {
                    ctl.Enabled = enable;
                }
            }
        }
        //deshabilitar controles TextBox sin instanciar metodo
        public static void enabledBotones(Control objeto, bool enable)
        {
            foreach (Control ctl in objeto.Controls)
            {
                if (ctl.GetType() == typeof(System.Windows.Forms.Button))
                {
                    ctl.Enabled = enable;
                }
            }
        }
        public static bool CheckIgualValues(string value1, string value2)
        {
            if (value1.Trim() == value2.Trim())
                return true;
            else
                return false;
        }
        public static bool CheckIgualValues(int value1, int value2)
        {
            if (value1 == value2)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Permite validar los permisos en controles Windows forms
        /// </summary>
        /// <param name="objetoContenedor"></param>
        public static void habilitarPermisos(Control objetoContenedor, int perfil)
        {
            try
            {
                foreach (Control ctrl in objetoContenedor.Controls)
                {
                    if (ctrl.Tag != null && ctrl.Tag.ToString().Length > 0)
                    {
                        QUERY Query = new QUERY();
                        string sql = "SELECT idRol,idComando FROM permiso p WHERE p.idRol = " + perfil + " and p.idComando ="+ ctrl.Tag +" order by p.idComando;";
                        DataTable DTP = Query.Consultar(sql);
                        if (DTP.Rows.Count > 0)
                            ctrl.Visible = true;
                        else
                            ctrl.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

    }

}
