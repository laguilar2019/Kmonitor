using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBM.CLS
{
    public class Metodos
    {
        public static string[,] Cargar_Lotes(DataTable Datos)
        {
            int Filas = 0;
            int Columnas = 0;
            string[,] Valores;
            Valores = new string[Datos.Rows.Count, Datos.Columns.Count];
            foreach (DataRow Row in Datos.Rows)
            {
                while (Columnas < Datos.Columns.Count)
                {
                    Valores[Filas, Columnas] = Row[Columnas].ToString();
                    Columnas = Columnas + 1;
                }
                Columnas = 0;
                Filas = Filas + 1;
            }
            return Valores;
        }

        //Clases para crear los botones
        public class IntEventArgs : EventArgs
        {
            // Creamos la clase IntEventArgs, derivada de EventArgs y que recibe una variable tipo int
            public IntEventArgs(int indice, String campo1)
            {
                this.indice = indice;
                this.campo1 = campo1;

            }
            public IntEventArgs(int indice, String campo1, String campo2)
            {
                this.indice = indice;
                this.campo1= campo1;
                this.campo2 = campo2;
            }
            public IntEventArgs(int indice, String campo1, String campo2,String campo3)
            {
                this.indice = indice;
                this.campo1 = campo1;
                this.campo2 = campo2;
                this.campo3 = campo3;
            }
            public IntEventArgs(int indice, String campo1, String campo2, String campo3, String campo4)
            {
                this.indice = indice;
                this.campo1 = campo1;
                this.campo2 = campo2;
                this.campo3 = campo3;
                this.campo4 = campo4;
            }
            public IntEventArgs(int indice, String campo1, String campo2, String campo3, String campo4, String campo5)
            {
                this.indice = indice;
                this.campo1 = campo1;
                this.campo2 = campo2;
                this.campo3 = campo3;
                this.campo4 = campo4;
                this.campo5 = campo5;
            }
            public int indice;
            public String campo1;
            public String campo2;
            public String campo3;
            public String campo4;
            public String campo5;

            //proobando para el di del producto y agregarlo a la grid
            // Creamos la clase IntEventArgs, derivada de EventArgs y que recibe una variable tipo int
        }
        public class myButton : System.Windows.Forms.Button
        {
            public int indice;   // Esta variable será la que contenga el índice dentro del vector de objetos
            public String campo1;
            public String campo2;
            public String campo3;
            public String campo4;
            public String campo5;
            public delegate void IntEventHandler(object sender, IntEventArgs e);  // Puntero hacia la clase IntEventHandler.
            public event IntEventHandler Click_ConIndice; // Evento
            public myButton()
            {

            }

            //  Cambiamos el método OnClick original del objeto Button por este código, lo que se hace es que al pulsar el botón, se dispara este evento en vez del original
            //  y este evento contiene el índice para poder distinguirlo del resto de botones
            protected override void OnClick(EventArgs e)
            {
                IntEventArgs eA1 = new IntEventArgs(indice, campo1, campo2, campo3, campo4, campo5);
                
                if (Click_ConIndice != null)
                    Click_ConIndice(this, eA1);
            }

        }
    }

}
