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

namespace TP_EJERCICIO_11
{
    public partial class Form_Operadores : Form
    {

        public Form_Operadores()
        {
            InitializeComponent();
        }

        private void grillaEnvios_SelectionChanged(object sender, EventArgs e)
        {
            if (grillaEnvios.SelectedRows.Count > 0)
            {
                int IndiceSeleccionado = grillaEnvios.SelectedCells[0].RowIndex; //conseguimos el indice de la celda seleccionada
                DataGridViewRow FilaSeleccionada = grillaEnvios.Rows[IndiceSeleccionado];
                string Estado = FilaSeleccionada.Cells["Estado"].Value.ToString();


                if (Estado == "Esperando aceptación del operador")
                { 
                    btnAceptar.Visible = true; btnEditarEstado.Visible = false; txtEstado.Visible = false; label2.Visible = false; txtMovil.Visible = true; label1.Visible = true;
                }
                else
                {
                    btnAceptar.Visible = false; btnEditarEstado.Visible = true; txtEstado.Visible = true; label2.Visible = true; txtMovil.Visible = false; label1.Visible = false;
                }
            }
        }

        private void Form_Operadores_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            txtEstado.Visible = false; btnEditarEstado.Visible = false;
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

                grillaEnvios.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6], datos[7], datos[8], datos[9], datos[10]);

                linea = LectorEnvios.ReadLine();
            }
            LectorEnvios.Close();
            ArchivoEnvios.Close();


            grillaMoviles.Rows.Clear();
            txtMovil.Items.Clear(); //Actualiza los items del comboBox Moviles
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
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int IndiceSeleccionado = grillaEnvios.SelectedCells[0].RowIndex; //conseguimos el indice de la celda seleccionada
                DataGridViewRow FilaSeleccionada = grillaEnvios.Rows[IndiceSeleccionado];
                string idPedido = FilaSeleccionada.Cells[0].Value.ToString();
                if(txtMovil.Text != "")
                {
                    FileStream ArchivoEnvios = new FileStream("Envios.csv", FileMode.OpenOrCreate, FileAccess.Read);
                    StreamReader LectorEnvios = new StreamReader(ArchivoEnvios);

                    FileStream ArchivoTemp = new FileStream("temp.csv", FileMode.Create, FileAccess.Write);
                    StreamWriter EscritorTemp = new StreamWriter(ArchivoTemp);

                    string linea = LectorEnvios.ReadLine();
                    string[] datos;
                    string lineaEscritura = "";

                    while (linea != null)
                    {
                        datos = linea.Split(';');
                        if (idPedido == datos[0] && datos[10] == "Esperando aceptación del operador") //Edita Si encuentra el ID y el estado "Esperando aceptación del operador"
                        {
                            //Editar archivo csv: Asignar un Movil y editar estado a "En preparacion"
                            lineaEscritura = datos[0] + ';' + datos[1] + ';' + datos[2] + ';' + datos[3] + ';' + datos[4] + ';' +
                                datos[5] + ';' + datos[6] + ';' + datos[7] + ';' + txtMovil.Text + ';' + datos[9] + ';' + "En preparación";
                            EscritorTemp.WriteLine(lineaEscritura);
                        }
                        else //Si no lo encuentra no edita nada.
                        {
                            lineaEscritura = datos[0] + ';' + datos[1] + ';' + datos[2] + ';' + datos[3] + ';' + datos[4] + ';' + datos[5] + ';' + datos[6] + ';' + datos[7] + ';' + datos[8] + ';' + datos[9] + ';' + datos[10];
                            EscritorTemp.WriteLine(lineaEscritura);
                        }
                        linea = LectorEnvios.ReadLine();
                    }
                    LectorEnvios.Close();
                    ArchivoEnvios.Close();
                    EscritorTemp.Close();
                    ArchivoTemp.Close();
                    File.Replace("temp.csv", "Envios.csv", "temp.csv.bak");
                    File.Delete("temp.csv");
                    File.Delete("temp.csv.bak");

                    ActualizarGrilla();
                }
                else { MessageBox.Show("Seleccione el movil para realizar la entrega del envío"); }
                
            }
            catch (Exception) { MessageBox.Show("Seleccione el Envío a aceptar"); }
        }

        private void btnEditarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                int IndiceSeleccionado = grillaEnvios.SelectedCells[0].RowIndex; //conseguimos el indice de la celda seleccionada
                DataGridViewRow FilaSeleccionada = grillaEnvios.Rows[IndiceSeleccionado];
                string idPedido = FilaSeleccionada.Cells[0].Value.ToString();
                if(txtEstado.Text != "")
                {
                    FileStream ArchivoEnvios = new FileStream("Envios.csv", FileMode.OpenOrCreate, FileAccess.Read);
                    StreamReader LectorEnvios = new StreamReader(ArchivoEnvios);
                    FileStream ArchivoTemp = new FileStream("temp.csv", FileMode.Create, FileAccess.Write);
                    StreamWriter EscritorTemp = new StreamWriter(ArchivoTemp);

                    string linea = LectorEnvios.ReadLine();
                    string[] datos;
                    string lineaEscritura = "";

                    while (linea != null)
                    {
                        datos = linea.Split(';');
                        if (idPedido == datos[0]) //Edita Si encuentra el ID
                        {
                            //Edita el estado del archivo CSV
                            lineaEscritura = datos[0] + ';' + datos[1] + ';' + datos[2] + ';' + datos[3] + ';' + datos[4] + ';' +
                                datos[5] + ';' + datos[6] + ';' + datos[7] + ';' + datos[8] + ';' + datos[9] + ';' + txtEstado.Text;
                            EscritorTemp.WriteLine(lineaEscritura);
                        }
                        else //Si no lo encuentra no edita nada.
                        { 
                            EscritorTemp.WriteLine(datos[0] + ';' + datos[1] + ';' + datos[2] + ';' + datos[3] + ';' + datos[4] + ';' + datos[5] + ';' + datos[6] + ';' + datos[7] + ';' + datos[8] + ';' + datos[9] + ';' + datos[10]);
                        }
                        linea = LectorEnvios.ReadLine();
                    }
                    LectorEnvios.Close();
                    ArchivoEnvios.Close();
                    EscritorTemp.Close();
                    ArchivoTemp.Close();
                    File.Replace("temp.csv", "Envios.csv", "temp.csv.bak");
                    File.Delete("temp.csv");
                    File.Delete("temp.csv.bak");

                    ActualizarGrilla();
                }
                else { MessageBox.Show("Seleccione el estado"); }
                
            }
            catch (Exception) { MessageBox.Show("Seleccione el Envío a editar"); }
        }
        }
}

