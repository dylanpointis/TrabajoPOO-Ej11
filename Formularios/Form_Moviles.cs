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

        private void Form_Moviles_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
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

                FileStream ArchivoMoviles = new FileStream("Moviles.csv", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader LectorMoviles = new StreamReader(ArchivoMoviles);
                FileStream ArchivoTemp = new FileStream("temp.csv", FileMode.Create, FileAccess.Write);
                StreamWriter EscritorTemp = new StreamWriter(ArchivoTemp);

                string linea = LectorMoviles.ReadLine();
                string[] datos;

                while (linea != null)
                {
                    datos = linea.Split(';');
                    if (NombreMovil != datos[0]) //SI EL NOMBRE DEL SELECCIONADO ES DISTINTO AL NOMBRE DEL CSV
                    {
                        //Escribe en el Temporal todos los que "Estan bien", o sea los que no quiero eliminar
                        EscritorTemp.WriteLine(linea);
                    }
                    linea = LectorMoviles.ReadLine();
                }
                LectorMoviles.Close();
                ArchivoMoviles.Close();
                EscritorTemp.Close();
                ArchivoTemp.Close();
                File.Replace("temp.csv", "Moviles.csv", "temp.csv.bak");
                File.Delete("temp.csv");
                File.Delete("temp.csv.bak");

                ActualizarGrilla();
            }
            catch (Exception ex) { MessageBox.Show("Seleccione el Móvil a eliminar"); }
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
            try
            {
                int IndiceSeleccionado = grillaMoviles.SelectedCells[0].RowIndex; 
                DataGridViewRow FilaSeleccionada = grillaMoviles.Rows[IndiceSeleccionado];
                string NombreMovil = FilaSeleccionada.Cells[0].Value.ToString();
                if (txtNombreMovil.Text != "" && txtNumeroMovil.Text != "")
                {
                    FileStream ArchivoMoviles = new FileStream("Moviles.csv", FileMode.OpenOrCreate, FileAccess.Read);
                    StreamReader LectorMoviles = new StreamReader(ArchivoMoviles);
                    FileStream ArchivoTemp = new FileStream("temp.csv", FileMode.Create, FileAccess.Write);
                    StreamWriter EscritorTemp = new StreamWriter(ArchivoTemp);

                    string linea = LectorMoviles.ReadLine();
                    string[] datos;
                    string lineaEscritura = "";

                    while (linea != null)
                    {
                        datos = linea.Split(';');
                        if (NombreMovil == datos[0]) 
                        {
                            
                            lineaEscritura = txtNombreMovil.Text + ';' + txtNumeroMovil.Text;
                            EscritorTemp.WriteLine(lineaEscritura);
                        }
                        else 
                        {
                            lineaEscritura = datos[0] + ';' + datos[1];
                            EscritorTemp.WriteLine(lineaEscritura);
                        }
                        linea = LectorMoviles.ReadLine();
                    }
                    LectorMoviles.Close();
                    ArchivoMoviles.Close();
                    EscritorTemp.Close();
                    ArchivoTemp.Close();
                    File.Replace("temp.csv", "Moviles.csv", "temp.csv.bak");
                    File.Delete("temp.csv");
                    File.Delete("temp.csv.bak");

                    ActualizarGrilla();
                }
                else { MessageBox.Show("Ingrese el nombre del móvil y el número del telefono"); }

            }
            catch (Exception) { MessageBox.Show("Seleccione el movil a editar"); } 
        }
    }
}
