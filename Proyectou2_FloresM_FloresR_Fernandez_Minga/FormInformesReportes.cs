using Proyectou2_FloresM_FloresR_Fernandez_Minga.Clases;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyectou2_FloresM_FloresR_Fernandez_Minga
{
    public partial class FormInformesReportes : Form
    {
        
        public FormInformesReportes()
        {
            InitializeComponent();
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            List<ClsAnimales> animales = ClsGestionArchivos.ObtenerAnimales();
            dgvAnimales.DataSource = animales;
        }

        private void btnMostrarAdoptante_Click(object sender, EventArgs e)
        {
            List<ClsAdoptantes> adoptantes = ClsGestionArchivos.ObtenerAdoptantes();
            dgvAdoptante.DataSource = adoptantes;
        }

        private void btnGenerarGrafico_Click(object sender, EventArgs e)
        {
            ActualizarGraficoPastel();
        }
        private void ActualizarGraficoPastel()
        {
            
            string filePath = "C:\\GestorArchivos\\Donaciones.txt";
            int donacionesEfectivo = 0;
            int donacionesYapePlin = 0;

            try
            {
                
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (line.Contains("Efectivo"))
                        {
                            donacionesEfectivo++;
                        }
                        else if (line.Contains("Yape/Plin"))
                        {
                            donacionesYapePlin++;
                        }
                    }
                }

               
                chartDonaciones.Series["Donaciones"].Points.Clear();
                chartDonaciones.Series["Donaciones"].Points.AddXY("Efectivo", donacionesEfectivo);
                chartDonaciones.Series["Donaciones"].Points.AddXY("Yape/Plin", donacionesYapePlin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
