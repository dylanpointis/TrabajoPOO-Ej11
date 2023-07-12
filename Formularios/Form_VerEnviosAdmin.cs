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
    public partial class Form_VerEnviosAdmin : Form
    {
        public Form_VerEnviosAdmin()
        {
            InitializeComponent();
        }

        private void Form_VerEnviosAdmin_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
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
        }
    }
}
