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
using Microsoft.VisualBasic;
using LibPrintTicket;

namespace PuntoDeVenta
{
    public partial class operador : Form
    {
        public operador()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void operador_Load(object sender, EventArgs e)
        {
            label1.Location = new Point(
                        Width / 2 - (label1.Width / 2),
                        35);

            lblTitulo.Location = new Point(
                        Width / 2 - (lblTitulo.Width / 2),
                        5);

            grid.Location = new Point(6,lblTitulo.Height + label1.Height + 20);
            grid.Width = Width - 12;
            grid.Height = Convert.ToInt32(Height - (Height * 0.25));
            box.Location = new Point(6, Height - (box.Height + 6));
            box.Width = Width - 12;
            grid.Columns[0].Width = Convert.ToInt32(grid.Width * 0.1);
            grid.Columns[1].Width = Convert.ToInt32(grid.Width * 0.5);
            grid.Columns[2].Width = Convert.ToInt32(grid.Width * 0.20);
            grid.Columns[3].Width = Convert.ToInt32((grid.Width * 0.20) - 3);
            box.Focus();
            total.Location = new Point(Width - total.Width, lblTitulo.Height + label1.Height + 20 + grid.Height);
            recarga.Location = new Point(Width - recarga.Width - 200, lblTitulo.Height + label1.Height + 20 + grid.Height);
            pagar.Location = new Point(Width - pagar.Width - 300, lblTitulo.Height + label1.Height + 20 + grid.Height);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)

            { grid.Rows.RemoveAt(grid.RowCount - 1);

            }
                if (e.KeyChar == 13) {
                string linea = null;
                using (StreamReader archivo = new StreamReader(@".\Data\productos.csv"))
                {
                    //while tab tab
                    while ((linea = archivo.ReadLine()) != null)
                    {
                        try
                        {
                            int cantidad = 1;
                            string producto = box.Text;

                            if (producto.Contains("*"))
                            {
                                cantidad = int.Parse(producto.Split('*')[0]);
                                producto = (producto.Split('*')[1]);
                            }

                            //MessageBox.Show(linea);
                            String[] elementos = linea.Split(',');
                            if (producto == elementos[0])
                            {
                                grid.Rows.Add(
                                       cantidad,
                                       elementos[1],
                                       elementos[2],
                                       int.Parse(elementos[2]) * cantidad
                                   );
                            }                            
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Hubo un error al intentar leer un archivo.");
                        }
                    }

                    box.Clear();
                    box.Focus();
                    //TODO Total
                    calc_total();

                    Repaint();
                }
            }
        }

        private void calc_total()
        {
            int sumatoria = 0;
            for (int i = 0; i < grid.RowCount; i++)
            {
                var res = grid[3, i].Value.ToString();
                sumatoria += Convert.ToInt32(grid[3, i].Value.ToString());
            }

            total.Text = "Total: " + sumatoria.ToString("$ 0.00");
            total.Location = new Point(Width-total.Width,
                label1.Height + lblTitulo.Height + 20 + grid.Height);
        }
        private void Repaint()
        {
            bool color = false;

            for (int renglon = 0; renglon < grid.RowCount; renglon++)
            {
                grid.Rows[renglon].HeaderCell.Value = String.Format("{0}", grid.Rows[renglon].Index + 1);
                if (color)
                {
                    //MessageBox.Show(linea);
                    grid.Rows[renglon].DefaultCellStyle.BackColor = Color.White;
                    color = false;
                }
                else
                {
                    //MessageBox.Show(linea);
                    grid.Rows[renglon].DefaultCellStyle.BackColor = Color.AliceBlue;
                    color = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pagar_Click(object sender, EventArgs e)
        {
            int tot = int.Parse(total.Text.Replace("Total: $ ", "").Replace(".00", ""));
            string pago = Interaction.InputBox("Pago total", "Pago", "0");
            try
            {
                int.Parse(pago);
                total.Text = "Cambio: " + (int.Parse(pago) - tot).ToString();

                imprimir();
            }
            catch {
                MessageBox.Show("Por favor ingrese un numero valido");
            }            
        }

        private void imprimir()
        {
            try
            {
                Ticket ticket = new Ticket();
                ticket.HeaderImage = Image.FromFile(
                    @"C:\Users\Joel\source\repos\PuntoDeVenta\PuntoDeVenta\Resources\logo.bmp");
                ticket.AddSubHeaderLine("Peluches dona chu");
                ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString());

                ticket.PrintTicket("EC-PM-5890X");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo imprimir :("+
                    " verifica la impresora " + 
                    ex.Message);
                
            }
        }
    }
}
