using System;
using System.IO;
using System.Windows.Forms;

namespace TP_EJERCICIO_11.Formularios
{
    public partial class Form_ReclamosClientes : Form
    {
        private string nombreDeUsuario;
        private string Nombre;
        private string Apellido;
        private string Mail;
        public Form_ReclamosClientes(Cliente unCliente)
        {
            InitializeComponent();
            this.nombreDeUsuario = unCliente.nombreDeUsuario;
            this.Nombre = unCliente.Nombre;
            this.Apellido = unCliente.Apellido;
            this.Mail = unCliente.Mail;
        }


        private void ReclamosClientes_Load(object sender, EventArgs e)
        {
            label1.Text = "RECLAMOS DE " + nombreDeUsuario;
            ActualizarGrilla();
        }

        private void btnRealizarReclamo_Click(object sender, EventArgs e)
        {
            if (txtIDPedido.Text != "" && txtProveedor.Text != "" && txtDescripcion.Text != "")
            {
                FileStream Archivo = new FileStream("Reclamos.csv", FileMode.Append, FileAccess.Write);
                StreamWriter Escritor = new StreamWriter(Archivo);
                string linea;
                DateTime fechaDeReclamo = DateTime.Now;

                linea = txtIDPedido.Text + ';' + nombreDeUsuario + ';' + txtProveedor.Text + ';' + txtDescripcion.Text + ';' + fechaDeReclamo.ToString("dd/MM/yyyy");
                Escritor.WriteLine(linea);
                Escritor.Close();
                Archivo.Close();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
        }



        private void ActualizarGrilla()
        {
            grillaReclamos.Rows.Clear();
            FileStream Archivo = new FileStream("Reclamos.csv", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader Lector = new StreamReader(Archivo);
            string linea = Lector.ReadLine();
            string[] datos;
            while (linea != null)
            {
                datos = linea.Split(';');
                if (nombreDeUsuario == datos[1])
                {
                    grillaReclamos.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4]);
                }
                linea = Lector.ReadLine();
            }
            Lector.Close();
            Archivo.Close();
        }
    }
}

