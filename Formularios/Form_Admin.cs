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
using Microsoft.VisualBasic;

namespace TP_EJERCICIO_11
{
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            string Rol = cmbRol.Text;
            string nombreDeUsuario = txtNombreDeUsuario.Text;
            string Clave = txtClave.Text;
            string Nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;
            string Mail = txtMail.Text;
            
            if(cmbRol.Text != "" && txtNombreDeUsuario.Text != "" && txtClave.Text!= "" && txtNombre.Text != "" && txtApellido.Text!= "" && txtMail.Text != "")
            {
                string Confirmar = Interaction.InputBox("Confirmar contraseña");
                if (Confirmar != "" && Clave == Confirmar)
                {
                    FileStream Archivo = new FileStream("Usuarios.csv", FileMode.Append, FileAccess.Write);
                    StreamWriter Escritor = new StreamWriter(Archivo);
                    string linea;
                    linea = nombreDeUsuario + ';' + Clave + ';' + Nombre + ';' + Apellido + ';' + Mail + ';' + Rol;
                    Escritor.WriteLine(linea);
                    Escritor.Close();
                    Archivo.Close();
                }
                else { MessageBox.Show("La contraseña y la confirmación no son iguales"); }

            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbRol.Text == "Proveedor")
            {
                label6.Text = "Nombre del proveedor";
                label7.Text = "Numero del proveedor";
            }
            else
            {
                label6.Text = "Nombre";
                label7.Text = "Apellido";
            }
        }
    }
}
