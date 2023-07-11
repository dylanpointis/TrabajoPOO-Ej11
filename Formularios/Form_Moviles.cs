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

namespace TP_EJERCICIO_11.Formularios
{
    public partial class Form_Moviles : Form
    {
        public Form_Moviles()
        {
            InitializeComponent();
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

                //seguir
            }
            catch (Exception ex) { MessageBox.Show("Seleccione el Móvil a eliminar"); }
        }

        private void Form_Moviles_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            grillaMoviles.Rows.Clear();
            FileStream ArchivoMoviles = new FileStream("Moviles.csv", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader LectorMoviles = new StreamReader(ArchivoMoviles);
            string[] datos;
            string linea = LectorMoviles.ReadLine();

            while (linea != null)
            {
                datos = linea.Split(';');
                grillaMoviles.Rows.Add(datos[0], datos[1]);
                linea = LectorMoviles.ReadLine();
            }
            LectorMoviles.Close();
            ArchivoMoviles.Close();
        }

        private void btnEditarMovil_Click(object sender, EventArgs e)
        {
            //fijarse como hice "editar estado" en form_operadores
        }
    }
}
