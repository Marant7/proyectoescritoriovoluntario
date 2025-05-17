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

namespace Proyectou2_FloresM_FloresR_Fernandez_Minga
{
    public partial class FormDonaciones : Form
    {
        ClsDonacion objDonacion;

        public FormDonaciones()
        {
            InitializeComponent();
            objDonacion = new ClsDonacion(pnlPregunta1, pnlPregunta2, pnlPregunta3, pnlPregunta4, pnlPregunta5);

            
        }

        private void btnEnviarDonacion_Click(object sender, EventArgs e)
        {
            objDonacion.SeleccionarRespuestaPregunta1();
            objDonacion.SeleccionarRespuestaPregunta2();
            objDonacion.SeleccionarRespuestaPregunta3();
            objDonacion.SeleccionarRespuestaPregunta4();
            objDonacion.SeleccionarRespuestaPregunta5();

            AgregarDatosAlArchivo();

            

            LimpiarRadioButton(pnlPregunta1);
            LimpiarRadioButton(pnlPregunta2);
            LimpiarRadioButton(pnlPregunta3);
            LimpiarRadioButton(pnlPregunta4);
            LimpiarRadioButton(pnlPregunta5);
            this.Dispose();

            MessageBox.Show("Enviado con exito", "Proceso de adopcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimpiarRadioButton(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
        }

        private void AgregarDatosAlArchivo()
        {
            string filePath = "C:\\GestorArchivos\\Donaciones.txt";

            string datos = " Pregunta 1:" + objDonacion.Pregunta1 + ", Pregunta 2:" + objDonacion.Pregunta2 + ", Pregunta 3:" + objDonacion.Pregunta3 + ", Pregunta 4:" + objDonacion.Pregunta4 + ", Pregunta 5:" + objDonacion.Pregunta5;

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(datos);
                }

                Console.WriteLine("Datos agregados al archivo con éxito en: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
