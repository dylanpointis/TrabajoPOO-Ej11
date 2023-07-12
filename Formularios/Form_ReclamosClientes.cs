using System;
using System.IO;
using System.Windows.Forms;
using TP_EJERCICIO_11.Clases;

namespace TP_EJERCICIO_11.Formularios
{
    public partial class Form_ReclamosClientes : Form
    {
        private string nombreDeUsuario;
        private string Nombre;
        private string Apellido;
        private string Mail;
        private string Rol;
        public Form_ReclamosClientes(Usuario unUsuario)
        {
            InitializeComponent();
            this.nombreDeUsuario = unUsuario.nombreDeUsuario;
            this.Nombre = unUsuario.Nombre;
            this.Apellido = unUsuario.Apellido;
            this.Mail = unUsuario.Mail;
            this.Rol = unUsuario.Rol;
        }


        private void ReclamosClientes_Load(object sender, EventArgs e)
        {
            if(Rol == "Cliente") { label1.Text = "RECLAMOS DEL CLIENTE " + nombreDeUsuario; }
            if (Rol == "Proveedor") { label1.Text = "RECLAMOS AL PROVEEDOR " + nombreDeUsuario; }

            if (Rol == "Proveedor" || Rol == "Operador")
            {
                btnRealizarReclamo.Visible = false; txtIDPedido.Visible = false; txtDescripcion.Visible = false; txtProveedor.Visible = false; label2.Visible = false; label3.Visible = false;  label4.Visible = false; btnEliminarMovil.Visible = false;
            }
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
                //Si el rol es cliente tiene que mostrar solo los reclamos de ese cliente. Si el rol es proveedor muestra solo los reclamos de ese proveedor. Si es admin u operador muestra todos
                if ((Rol == "Cliente" && nombreDeUsuario == datos[1]) || (Rol == "Proveedor" && nombreDeUsuario == datos[2]) || (Rol == "Operador") || (Rol == "Admin"))
                {
                    grillaReclamos.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4]);
                }

                linea = Lector.ReadLine();
            }
            Lector.Close();
            Archivo.Close();
        }

        private void btnEliminarMovil_Click(object sender, EventArgs e)
        {
            try
            {
                int IndiceSeleccionado = grillaReclamos.SelectedCells[0].RowIndex; //conseguimos el indice de la celda seleccionada
                DataGridViewRow FilaSeleccionada = grillaReclamos.Rows[IndiceSeleccionado];
                string idPedidoReclamado = FilaSeleccionada.Cells[0].Value.ToString();

                FileStream Archivo = new FileStream("Reclamos.csv", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader Lector = new StreamReader(Archivo);
                FileStream ArchivoTemp = new FileStream("temp.csv", FileMode.Create, FileAccess.Write);
                StreamWriter EscritorTemp = new StreamWriter(ArchivoTemp);

                string linea = Lector.ReadLine();
                string[] datos;

                while (linea != null)
                {
                    datos = linea.Split(';');
                    if (idPedidoReclamado != datos[0]) //SI EL Id del Pedido SELECCIONADO ES DISTINTO AL NOMBRE DEL CSV
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
                File.Replace("temp.csv", "Reclamos.csv", "temp.csv.bak");
                File.Delete("temp.csv");
                File.Delete("temp.csv.bak");

                ActualizarGrilla();
            }
            catch (Exception ex) { MessageBox.Show("Seleccione el Reclamo a eliminar"); }
        }
    }
}

