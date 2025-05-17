using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectou2_FloresM_FloresR_Fernandez_Minga
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            
        }

        private void btnGestionAnimales_Click(object sender, EventArgs e)
        {
            FormGestionAnimales formGestionAnimales = new FormGestionAnimales();
            formGestionAnimales.ShowDialog();
        }

        private void btnGestionAdoptantes_Click(object sender, EventArgs e)
        {
            FormGestionAdoptantes formGestionAdoptantes = new FormGestionAdoptantes();
            formGestionAdoptantes.ShowDialog();
        }

        private void btnInformesReportes_Click(object sender, EventArgs e)
        {
            FormInformesReportes formInformesReportes = new FormInformesReportes();
            formInformesReportes.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }

        private void btnProcesoAdopcion_Click(object sender, EventArgs e)
        {
            FormProcesoAdopcion formProcesoAdopcion = new FormProcesoAdopcion();
            formProcesoAdopcion.ShowDialog();
        }

        private void btnDonacion_Click(object sender, EventArgs e)
        {
            FormDonaciones formDonacion = new FormDonaciones();
            formDonacion.ShowDialog();
        }
    }
}
