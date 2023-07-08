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

namespace TP_EJERCICIO_11.Formularios
{
    public partial class Form_Proveedor : Form
    {
        private string nombreDeUsuario;
        private string NombreProv;
        private string ApellidoProv;
        private string MailProv;

        public Form_Proveedor(Proveedor unProveedor)
        {
            InitializeComponent();
            this.nombreDeUsuario = unProveedor.nombreDeUsuario;
            this.NombreProv = unProveedor.Nombre;
            this.ApellidoProv = unProveedor.Apellido;
            this.MailProv = unProveedor.Mail;
        }

        private void Form_Proveedor_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            labelEnvios.Text = "Grilla envíos de: " + NombreProv + " " + ApellidoProv;
        }

        private void btnRegistrarPedido_Click(object sender, EventArgs e)
        {
            if (txtIDPedido.Text != "" && txtCliente.Text != "" && txtDescripcion.Text != "" && txtCosto.Text != "" && txtPeso.Text != "" && txtSalida.Text != "" && txtDestino.Text != "" && txtMovil.Text != "")
            {
                FileStream Archivo = new FileStream("Envios.csv", FileMode.Append, FileAccess.Write);
                StreamWriter Escritor = new StreamWriter(Archivo);
                string linea;
                DateTime fechaDeEntrega = DateTime.Now.AddDays(3);// LA FECHA DE ENTREGA ES 72 HORAS DESPUES DE REGISTRAR EL PEDIDO

                linea = nombreDeUsuario + ';' + txtIDPedido.Text +';' + txtCliente.Text + ';' + txtDescripcion.Text + ';' + txtCosto.Text + ';' + txtPeso.Text + ';' + txtSalida.Text + ';' + txtDestino.Text + ';' + txtMovil.Text + ';' + fechaDeEntrega.ToString("dd/MM/yyyy") + ';' + "En preparación";
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
            grillaEnvios.Rows.Clear();
            FileStream ArchivoEnvios = new FileStream("Envios.csv", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader LectorEnvios = new StreamReader(ArchivoEnvios);
            string linea = LectorEnvios.ReadLine();

            string[] datos;

            while (linea != null)
            {
                datos = linea.Split(';');
                if (nombreDeUsuario == datos[0])
                {
                    grillaEnvios.Rows.Add(datos[1], datos[2], datos[3], datos[4], datos[5], datos[6], datos[7] , datos[8], datos[9], datos[10]);
                }
                linea = LectorEnvios.ReadLine();
            }
            LectorEnvios.Close();
            ArchivoEnvios.Close();



            grillaMoviles.Rows.Clear();
            FileStream ArchivoMoviles = new FileStream("Moviles.csv", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader LectorMoviles = new StreamReader(ArchivoMoviles);
            linea = LectorMoviles.ReadLine();

            while (linea != null)
            {
                datos = linea.Split(';');
                grillaMoviles.Rows.Add(datos[0], datos[1]);
                txtMovil.Items.Add(datos[0]);
                linea = LectorMoviles.ReadLine();
            }
            LectorMoviles.Close();
            ArchivoMoviles.Close();



            grillaClientes.Rows.Clear();
            FileStream ArchivoClientes = new FileStream("Usuarios.csv", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader LectorClientes = new StreamReader(ArchivoClientes);
            linea = LectorClientes.ReadLine();

            while (linea != null)
            {
                datos = linea.Split(';');
                if(datos[5] == "Cliente")
                {
                    grillaClientes.Rows.Add(datos[0],datos[2], datos[3], datos[4]);
                    txtCliente.Items.Add(datos[0]);
                }
                
                linea = LectorClientes.ReadLine();
            }
            LectorClientes.Close();
            ArchivoClientes.Close();
        }

        private void btnRegistrarMovil_Click(object sender, EventArgs e)
        {
            if (txtNombreMovil.Text != "" && txtNumeroMovil.Text != "")
            {
                FileStream Archivo = new FileStream("Moviles.csv", FileMode.Append, FileAccess.Write);
                StreamWriter Escritor = new StreamWriter(Archivo);
                string linea;
               

                linea = txtNombreMovil.Text + ';' + txtNumeroMovil.Text;
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

        private void btnEliminarMovil_Click(object sender, EventArgs e)
        {
            try
            {
                int IndiceSeleccionado = grillaMoviles.SelectedCells[0].RowIndex; //conseguimos el indice de la celda seleccionada
                DataGridViewRow FilaSeleccionada = grillaMoviles.Rows[IndiceSeleccionado];
                string NombreMovil = FilaSeleccionada.Cells[0].Value.ToString();

                // NO SE COMO ELIMINAR SEGUN EL NOMBRE
            }
            catch(Exception ex) { MessageBox.Show("Seleccione el Movil a eliminar");}
        }
    }
}
