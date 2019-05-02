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
            using (StreamReader archivo = new StreamReader(@".\Data\productos.csv"))
            {
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
                Repaint();
            }
        }

        private void Repaint()
        {
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

        private void Clear() {
            txtCodigo.Enabled = true;
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtURL.Clear();
            //TODO next
        }

        private bool EsValido()
        {
            if (String.IsNullOrWhiteSpace(txtCodigo.Text)) return false;
            if (String.IsNullOrWhiteSpace(txtNombre.Text)) return false;
            if (String.IsNullOrWhiteSpace(txtPrecio.Text)) return false;
            if (String.IsNullOrWhiteSpace(txtURL.Text)) return false;
            if (String.IsNullOrWhiteSpace(txtNombre.Text)) return false;

            return true;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (EsValido())
            {
                dataGridView1.Rows.Add(txtCodigo.Text,
                    txtNombre.Text,
                    txtPrecio.Text,
                    txtURL.Text);

                Repaint();
            }
            else { MessageBox.Show("Revisa los campos requeridos"); }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectAll();
            DataObject obj = dataGridView1.GetClipboardContent();
            File.WriteAllText(@".\Data\productos.csv", obj.GetText(TextDataFormat.CommaSeparatedValue));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtCodigo.Enabled = false;

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtCodigo.Text = row.Cells[0].Value.ToString();
                txtNombre.Text = row.Cells[1].Value.ToString();
                txtPrecio.Text = row.Cells[2].Value.ToString();
                txtURL.Text = row.Cells[3].Value.ToString();
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[0, i].Value.ToString() == txtCodigo.Text)
                {
                    dataGridView1.Rows.RemoveAt(i);
                }
            }

            Repaint();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (txtCodigo.Text == dataGridView1[0,i].Value)
                {
                    dataGridView1[1, i].Value = txtNombre.Text;
                    //TODO los demas
                }
            }
        }
    }
}
