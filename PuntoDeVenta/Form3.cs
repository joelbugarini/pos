using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // Este metodo se ejecuta cuando se carga la forma c:
        //Form1_Load
        private void Form3_Load(object sender, EventArgs e)
        {
            // añeñe
            Cargar_CSV();
        }
        // Este metodo bla bla
        private void Cargar_CSV()
        {
            string linea = null;
            StreamReader archivo = new StreamReader(@"C:\Users\Joel\source\repos\PuntoDeVenta\PuntoDeVenta\Resources\productos.csv");
            //while tab tab
            while ((linea = archivo.ReadLine()) != null)
            {
                try
                {
                    //MessageBox.Show(linea);
                    String[] elementos = linea.Split(',');
                    dataGridView1.Rows.Add(
                        elementos[0],
                        elementos[1],
                        elementos[2],
                        elementos[3],
                        Image.FromFile(elementos[3])
                    );
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error al intentar leer un archivo.");
                }                
            }
        }
    }
}
