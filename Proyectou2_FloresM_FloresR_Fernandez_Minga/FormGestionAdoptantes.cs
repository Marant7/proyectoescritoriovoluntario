using Proyectou2_FloresM_FloresR_Fernandez_Minga.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectou2_FloresM_FloresR_Fernandez_Minga
{
    public partial class FormGestionAdoptantes : Form
    {
        private ClsAdoptantes nuevoAdoptante;
        public FormGestionAdoptantes()
        {
            InitializeComponent();
            cmbGeneroAdoptante.Items.Add("Hombre");
            cmbGeneroAdoptante.Items.Add("Mujer");
            cmbGeneroAdoptante.Items.Add("Otro");
            
        }

        private void btnRegistrarAdoptante_Click(object sender, EventArgs e)
        {
            int idAdoptante = int.Parse(txtIdAdoptante.Text);
            if (ClsGestionArchivos.ExisteAdoptanteConID(idAdoptante))
            {
                MessageBox.Show("Ya existe un adoptante con este ID. Por favor, elija otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                int dni = int.Parse(txtDni.Text);
                string nombres = txtNombre.Text;
                string apellidos = txtApellido.Text;
                string direccion = txtDireccion.Text;
                int edad = int.Parse(txtEdad.Text);
                string genero = cmbGeneroAdoptante.SelectedItem.ToString();
                int telefono = int.Parse(txtTelefono.Text);

                nuevoAdoptante = new ClsAdoptantes(idAdoptante, dni, nombres, apellidos, direccion,  edad, genero, telefono);
                ClsGestionArchivos.AgregarAdoptante(nuevoAdoptante);
                MessageBox.Show("Fue Registrado exitosamente", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMostrarAdoptante_Click(object sender, EventArgs e)
        {
           
        }

        private void btnModificarAdoptante_Click(object sender, EventArgs e)
        {
            FrmModificarAdoptantes formModificar = new FrmModificarAdoptantes();
            formModificar.ShowDialog();
        }
    }
}
