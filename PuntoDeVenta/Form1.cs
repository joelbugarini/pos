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

namespace PuntoDeVenta
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // Este metodo se ejecuta cuando se carga la forma c:
        //Form1_Load
        private void Usuarios_Load(object sender, EventArgs e)
        {
            // añeñe
            Cargar_CSV();
        }
        // Este metodo bla bla
        private void Cargar_CSV()
        {
            string linea = null;
            StreamReader archivo = new StreamReader(@"C:\Users\Joel\source\repos\PuntoDeVenta\PuntoDeVenta\Resources\usuarios.csv");
            //while tab tab
            while ((linea = archivo.ReadLine()) != null)
            {
                //MessageBox.Show(linea);
                dataGridView1.Rows.Add(linea.Split(','));
            }
        }
    }
}
