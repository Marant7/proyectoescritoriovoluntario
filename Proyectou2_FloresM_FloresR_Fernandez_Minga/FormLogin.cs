using Proyectou2_FloresM_FloresR_Fernandez_Minga.Clases;
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
    public partial class FormLogin : Form
    {
        ClsGestionArchivos gestionArchivos = new ClsGestionArchivos();

        public FormLogin()
        {
            InitializeComponent();
            
        }
        
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (gestionArchivos.AutenticarUsuario(nombreUsuario, contraseña))
            {
                // Autenticación exitosa
                lblMensaje.Text = "Inicio de sesión exitoso";
                // Aquí puedes abrir el formulario principal o realizar otras acciones necesarias.
                FormPrincipal formularioPrincipal = new FormPrincipal();
                formularioPrincipal.Show();
                this.Hide(); // Oculta el formulario de inicio de sesión

            }
            else
            {
                // Error en la autenticación
                lblMensaje.Text = "Nombre de usuario o contraseña incorrectos";
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
