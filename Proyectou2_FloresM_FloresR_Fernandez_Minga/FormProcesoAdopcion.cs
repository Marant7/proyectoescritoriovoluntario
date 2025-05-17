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
    public partial class FormProcesoAdopcion : Form
    {
        string direccion, ocupacion, gastomascota;
        int edadniñopeque;

        ClsAdopcion objAdopcion;
        public FormProcesoAdopcion()
        {
            InitializeComponent();
            objAdopcion = new ClsAdopcion(pnlPregunta1, pnlPregunta2, pnlPregunta3, pnlPregunta4, pnlPregunta5, pnlPregunta6);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            direccion = txtDireccion.Text;
            ocupacion = txtOcupacion.Text;
            edadniñopeque = Convert.ToInt32(txtEdadniño.Text);

            if (edadniñopeque > 0 && edadniñopeque <= 10)
            {
                gastomascota = txtGastoMascota.Text;

                objAdopcion.IngresarDatos(direccion, ocupacion, edadniñopeque, gastomascota);
                objAdopcion.SeleccionarRespuestaPregunta1();
                objAdopcion.SeleccionarRespuestaPregunta2();
                objAdopcion.SeleccionarRespuestaPregunta3();
                objAdopcion.SeleccionarRespuestaPregunta4();
                objAdopcion.SeleccionarRespuestaPregunta5();
                objAdopcion.SeleccionarRespuestaPregunta6();

                AgregarDatosAlArchivo();

                txtDireccion.Clear();
                txtOcupacion.Clear();
                txtGastoMascota.Clear();
                txtEdadniño.Clear();
                LimpiarRadioButton(pnlPregunta1);
                LimpiarRadioButton(pnlPregunta2);
                LimpiarRadioButton(pnlPregunta3);
                LimpiarRadioButton(pnlPregunta4);
                LimpiarRadioButton(pnlPregunta5);
                LimpiarRadioButton(pnlPregunta6);
                this.Dispose();

                MessageBox.Show("Enviado con exito", "Proceso de adopcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Edad de niño ingresado fuera del límite.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


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
            string filePath = "C:\\GestorArchivos\\Proceso de Adopcion.txt";

            string datos = "DATOS" + " ,Dirección: " + objAdopcion.Direccion + ", Ocupación: " + objAdopcion.Ocupacion + ", Edad del Niño Pequeño: " + objAdopcion.EdadNiñoPeque + ", Gasto en Mascota: " + objAdopcion.GastoMascota + "\r\n" +
                "PREGUNTAS DE SELECCION" + " ,Pregunta 1:" + objAdopcion.Pregunta1 + ", Pregunta 2:" + objAdopcion.Pregunta2 + ", Pregunta 3:" + objAdopcion.Pregunta3 + ", Pregunta 4:" + objAdopcion.Pregunta4 + ", Pregunta 5:" + objAdopcion.Pregunta5 + ", Pregunta 6:" + objAdopcion.Pregunta6;

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
