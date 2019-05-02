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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            using (StreamReader archivo = new StreamReader(@".\Data\usuarios.csv"))
            {
                string linea = null;
                //while tab tab

                if (string.IsNullOrWhiteSpace(txtContrasena.Text) || 
                    string.IsNullOrWhiteSpace(txtUsuario.Text))
                    MessageBox.Show("Porfavor llene ambos campos");

                bool denied = true;
                string rol = "";

                while ((linea = archivo.ReadLine()) != null)
                {
                    if (linea.Split(',').ElementAt(1) == txtUsuario.Text)
                    {
                        if (linea.Split(',').ElementAt(2) == txtContrasena.Text)
                        {
                            denied = false;
                            rol = linea.Split(',').ElementAt(6);
                        }
                    }
                    
                }

                if (denied)
                {
                    MessageBox.Show("Acceso denegado");
                }
                else
                {
                    MessageBox.Show("Bienvenido " + rol);
                    switch (rol)
                    {
                        case "Operador":
                            new operador().Show();
                            break;
                        case "Administrador":
                            new administrador().Show();
                            break;
                    }
                }
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Login();
            }
        }
        
    }
}
