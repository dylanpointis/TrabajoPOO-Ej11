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
            ActualizarGrilla();
        }

        private void btnBajaPedido_Click(object sender, EventArgs e)
        {
            try
            {
                int IndiceSeleccionado = grillaEnvios.SelectedCells[0].RowIndex; //conseguimos el indice de la celda seleccionada
                DataGridViewRow FilaSeleccionada = grillaEnvios.Rows[IndiceSeleccionado];
                string idPedido = FilaSeleccionada.Cells[0].Value.ToString();

                FileStream Archivo = new FileStream("Envios.csv", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader Lector = new StreamReader(Archivo);
                FileStream ArchivoTemp = new FileStream("temp.csv", FileMode.Create, FileAccess.Write);
                StreamWriter EscritorTemp = new StreamWriter(ArchivoTemp);

                string linea = Lector.ReadLine();
                string[] datos;

                while (linea != null)
                {
                    datos = linea.Split(';');
                    if (idPedido != datos[0]) //SI EL Id del Pedido SELECCIONADO ES DISTINTO AL NOMBRE DEL CSV
                    {
                        //Escribe en el Temporal todos los que "Estan bien", o sea los que no quiero eliminar
                        EscritorTemp.WriteLine(linea);
                    }
                    linea = Lector.ReadLine();
                }
                Lector.Close();
                Archivo.Close();
                EscritorTemp.Close();
                ArchivoTemp.Close();
                File.Replace("temp.csv", "Envios.csv", "temp.csv.bak");
                File.Delete("temp.csv");
                File.Delete("temp.csv.bak");

                ActualizarGrilla();
            }
            catch (Exception ex) { MessageBox.Show("Seleccione el pedido a dar de baja"); }
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
