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

            //presta esa cosa maravillosa, combo box
            cmbTipo.Text = cmbTipo.Items[0].ToString();
        }
        
        // Este metodo bla bla
        private void Cargar_CSV()
        {
            string linea = null;
            
            using (StreamReader archivo = new StreamReader(@".\Data\usuarios.csv"))
            {
                //while tab tab
                while ((linea = archivo.ReadLine()) != null)
                {
                    dataGridView1.Rows.Add(linea.Split(','));
                    Repaint();
                }
            }
        }

        private void Repaint() {
            bool color = false;

            for (int renglon = 0; renglon < dataGridView1.RowCount; renglon++)
            {
                dataGridView1.Rows[renglon].HeaderCell.Value = String.Format("{0}", dataGridView1.Rows[renglon].Index + 1);
                if (color)
                {
                    //MessageBox.Show(linea);
                    dataGridView1.Rows[renglon].DefaultCellStyle.BackColor = Color.White;
                    color = false;
                }
                else
                {
                    //MessageBox.Show(linea);
                    dataGridView1.Rows[renglon].DefaultCellStyle.BackColor = Color.AliceBlue;
                    color = true;
                }
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (EsValido())
            {
                dataGridView1.Rows.Add(txtId.Text,
                    txtUsuario.Text,
                    txtPassword.Text,
                    txtApellidoUno.Text,
                    txtApellidoDos.Text,
                    txtNombre.Text,
                    cmbTipo.Text);

                Repaint();
            }
            else { MessageBox.Show("Revisa los campos requeridos"); }
        }

        private bool EsValido()
        {
            if (String.IsNullOrWhiteSpace(txtId.Text)) return false;
            if (String.IsNullOrWhiteSpace(txtNombre.Text)) return false;
            if (String.IsNullOrWhiteSpace(txtPassword.Text)) return false;
            if (String.IsNullOrWhiteSpace(txtApellidoUno.Text)) return false;
            if (String.IsNullOrWhiteSpace(txtUsuario.Text)) return false;

            return true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtUsuario.Text = row.Cells[1].Value.ToString();
                txtPassword.Text = row.Cells[2].Value.ToString();
                txtApellidoUno.Text = row.Cells[3].Value.ToString();
                txtApellidoDos.Text = row.Cells[4].Value.ToString();
                txtNombre.Text = row.Cells[5].Value.ToString();
                cmbTipo.Text = row.Cells[6].Value.ToString();
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[0, i].Value.ToString() == txtId.Text)
                {
                    dataGridView1.Rows.RemoveAt(i);
                }
            }

            Repaint();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectAll();
            DataObject obj = dataGridView1.GetClipboardContent();
            File.WriteAllText(@".\Data\usuarios.csv",obj.GetText(TextDataFormat.CommaSeparatedValue));
        }
    }
}