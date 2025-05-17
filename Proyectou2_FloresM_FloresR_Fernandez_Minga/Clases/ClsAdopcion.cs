using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectou2_FloresM_FloresR_Fernandez_Minga.Clases
{
    public class ClsAdopcion
    {
        public string Direccion { get; set; }
        public string Ocupacion { get; set; }
        public int EdadNiñoPeque { get; set; }
        public string GastoMascota { get; set; }
        public string Pregunta1 { get; set; }
        public string Pregunta2 { get; set; }
        public string Pregunta3 { get; set; }
        public string Pregunta4 { get; set; }
        public string Pregunta5 { get; set; }
        public string Pregunta6 { get; set; }

        private Panel panelPregunta1;
        private Panel panelPregunta2;
        private Panel panelPregunta3;
        private Panel panelPregunta4;
        private Panel panelPregunta5;
        private Panel panelPregunta6;

        public ClsAdopcion(Panel pnlPregunta1, Panel pnlPregunta2, Panel pnlPregunta3, Panel pnlPregunta4, Panel pnlPregunta5, Panel pnlPregunta6)
        {
            panelPregunta1 = pnlPregunta1;
            panelPregunta2 = pnlPregunta2;
            panelPregunta3 = pnlPregunta3;
            panelPregunta4 = pnlPregunta4;
            panelPregunta5 = pnlPregunta5;
            panelPregunta6 = pnlPregunta6;
        }

        //metodos
        public void IngresarDatos(string dir, string ocup, int edadnipe, string gastomasco)
        {
            this.Direccion = dir;
            this.Ocupacion = ocup;
            this.EdadNiñoPeque = edadnipe;
            this.GastoMascota = gastomasco;
        }

        public void SeleccionarRespuestaPregunta1()
        {
            foreach (Control control in panelPregunta1.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    Pregunta1 = radioButton.Text;
                    break;
                }
            }
        }
        public void SeleccionarRespuestaPregunta2()
        {
            foreach (Control control in panelPregunta2.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    Pregunta2 = radioButton.Text;
                    break;
                }
            }
        }
        public void SeleccionarRespuestaPregunta3()
        {
            foreach (Control control in panelPregunta3.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    Pregunta3 = radioButton.Text;
                    break;
                }
            }
        }
        public void SeleccionarRespuestaPregunta4()
        {
            foreach (Control control in panelPregunta4.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    Pregunta4 = radioButton.Text;
                    break;
                }
            }
        }
        public void SeleccionarRespuestaPregunta5()
        {
            foreach (Control control in panelPregunta5.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    Pregunta5 = radioButton.Text;
                    break;
                }
            }
        }
        public void SeleccionarRespuestaPregunta6()
        {
            foreach (Control control in panelPregunta6.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    Pregunta6 = radioButton.Text;
                    break;
                }
            }
        }
    }
}

