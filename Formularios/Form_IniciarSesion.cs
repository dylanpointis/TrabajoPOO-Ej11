using Microsoft.VisualBasic;
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
using TP_EJERCICIO_11.Clases;

namespace TP_EJERCICIO_11
{
    public partial class Form_IniciarSesion : Form
    {
        public Form_IniciarSesion()
        {
            InitializeComponent();
        }
        private void Form_IniciarSesion_Load(object sender, EventArgs e)
        {
            //txtNombreDeUsuario.Text = "EstebanRodriguez";
            //txtClave.Text = "1";
            txtNombreDeUsuario.Text = "3";
            txtClave.Text = "3";
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Form_Registrarse formulario = new Form_Registrarse();
            this.Show(); //oculta el formulario actual
            formulario.Show();
            formulario.FormClosing += CerrandoFormulario; //cuando se cierra el formulario de Registrarse ejecuta la funcion CerrandoFormulario que vuelve a mostrar el formulario actual
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
             string nombreDeUsuario = txtNombreDeUsuario.Text;
            string Clave = txtClave.Text;
            bool inicioSesionExitoso = false;

            if (txtNombreDeUsuario.Text != "" & txtClave.Text != "")
            {
                FileStream Archivo = new FileStream("Usuarios.csv", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader Lector = new StreamReader(Archivo);
                string linea = Lector.ReadLine();

                string[] datos;

                while (linea != null)
                {
                    datos = linea.Split(';');

                    if (nombreDeUsuario == datos[0] && Clave == datos[1])
                    {
                        string Nombre = datos[2];
                        string Apellido = datos[3];
                        string Mail = datos[4];
                        string Rol = datos[5];

                        inicioSesionExitoso = true;
                        this.Hide(); //oculta el formulario actual
                        Usuario unUsuario = new Usuario(nombreDeUsuario, Clave, Nombre, Apellido, Mail, Rol);
                        Form_General formulario = new Form_General(unUsuario);
                        formulario.Show();
                        formulario.FormClosing += CerrandoFormulario; //cuando se cierra el formulario clientes ejecuta la funcion CerrandoFormulario que vuelve a mostrar el formulario actual

                    }
                    linea = Lector.ReadLine();
                }
                Lector.Close();
                Archivo.Close();

                if (inicioSesionExitoso == false)
                {
                    MessageBox.Show("Datos incorrectos");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese su nombre de usuario y contraseña");
            }
        }

        private void CerrandoFormulario(object sender, FormClosingEventArgs e)
        {
            this.Show();
            txtNombreDeUsuario.Text = "";
            txtClave.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmostrarcuentas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EstebanRodriguez;1;Cliente\n1;1;Admin \n2;2;Proveedor\n3;3;Operador");
        }
    }
}
