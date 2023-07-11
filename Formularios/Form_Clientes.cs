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

namespace TP_EJERCICIO_11
{
    public partial class Form_Clientes : Form
    {
        private string nombreDeUsuario;
        private string Nombre;
        private string Apellido;
        private string Mail;


        public Form_Clientes(Cliente unCliente)
        {
            InitializeComponent();
            this.nombreDeUsuario = unCliente.nombreDeUsuario;
            this.Nombre = unCliente.Nombre;
            this.Apellido = unCliente.Apellido;
            this.Mail = unCliente.Mail;
        }

        private void Form_Clientes_Load(object sender, EventArgs e)
        {
            label1.Text = "Bienvenido " + Nombre + " " + Apellido;
            labelEnvios.Text = "Grilla de pedidos de: " + Nombre + " " + Apellido;


            grillaEnvios.Rows.Clear();
            FileStream ArchivoEnvios = new FileStream("Envios.csv", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader LectorEnvios = new StreamReader(ArchivoEnvios);
            string linea = LectorEnvios.ReadLine();

            string[] datos;

            while (linea != null)
            {
                datos = linea.Split(';');
                if (nombreDeUsuario == datos[2])
                {
                    grillaEnvios.Rows.Add(datos[0], datos[1], datos[3], datos[4], datos[6], datos[7], datos[7], datos[8], datos[9], datos[10]);

                }
                linea = LectorEnvios.ReadLine();
            }
            LectorEnvios.Close();
            ArchivoEnvios.Close();
        }
    }
}
