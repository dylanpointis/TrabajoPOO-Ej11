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
    public partial class Form_Demoras : Form
    {
        private string nombreDeUsuario;
        private string Nombre;
        private string Apellido;
        private string Mail;
        private string Rol;
        public Form_Demoras(Usuario unUsuario)
        {
            InitializeComponent();
            this.nombreDeUsuario = unUsuario.nombreDeUsuario;
            this.Nombre = unUsuario.Nombre;
            this.Apellido = unUsuario.Apellido;
            this.Mail = unUsuario.Mail;
            this.Rol = unUsuario.Rol;
        }

        private void Form_Demoras_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            if (Rol == "Cliente" || Rol == "Proveedor") 
            {
                btnEliminarDemora.Visible = false; btnRegistrarDemora.Visible = false; txtID.Visible = false;txtMotivo.Visible = false; label2.Visible = false; label3.Visible=false ;
            } 
        }

        private void ActualizarGrilla()
        {
            grillaDemoras.Rows.Clear();
            FileStream Archivo = new FileStream("Demoras.csv", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader Lector = new StreamReader(Archivo);
            string linea = Lector.ReadLine();
            string[] datos;
            while (linea != null)
            {
                datos = linea.Split(';');
                grillaDemoras.Rows.Add(datos[0], datos[1]);
                linea = Lector.ReadLine();
            }
            Lector.Close();
            Archivo.Close();
        }

        private void btnRegistrarDemora_Click(object sender, EventArgs e)
        {
            if(txtID.Text != "" && txtMotivo.Text != "")
            {
                FileStream Archivo = new FileStream("Demoras.csv", FileMode.Append, FileAccess.Write);
                StreamWriter Escritor = new StreamWriter(Archivo);
                string linea = txtID.Text + ';' + txtMotivo.Text;
                Escritor.WriteLine(linea);
                Escritor.Close();
                Archivo.Close();
                ActualizarGrilla();

            }
            else { MessageBox.Show("Debe llenar todos los campos"); }
        }

        private void btnEliminarDemora_Click(object sender, EventArgs e)
        {
            try
            {
                int IndiceSeleccionado = grillaDemoras.SelectedCells[0].RowIndex; //conseguimos el indice de la celda seleccionada
                DataGridViewRow FilaSeleccionada = grillaDemoras.Rows[IndiceSeleccionado];
                string idPedidoDemorado = FilaSeleccionada.Cells[0].Value.ToString();

                FileStream Archivo = new FileStream("Demoras.csv", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader Lector = new StreamReader(Archivo);
                FileStream ArchivoTemp = new FileStream("temp.csv", FileMode.Create, FileAccess.Write);
                StreamWriter EscritorTemp = new StreamWriter(ArchivoTemp);

                string linea = Lector.ReadLine();
                string[] datos;

                while (linea != null)
                {
                    datos = linea.Split(';');
                    if (idPedidoDemorado != datos[0]) //SI EL NOMBRE DEL SELECCIONADO ES DISTINTO AL NOMBRE DEL CSV
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
                File.Replace("temp.csv", "Demoras.csv", "temp.csv.bak");
                File.Delete("temp.csv");
                File.Delete("temp.csv.bak");

                ActualizarGrilla();
            }
            catch (Exception ex) { MessageBox.Show("Seleccione el Móvil a eliminar"); }
        }
    }
}
