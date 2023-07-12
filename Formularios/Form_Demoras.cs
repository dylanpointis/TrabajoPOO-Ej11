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
            if (Rol == "Admin" || Rol == "Operador") 
            {
                btnEliminarDemora.Visible = true; btnRegistrarDemora.Visible = true;
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
    }
}
