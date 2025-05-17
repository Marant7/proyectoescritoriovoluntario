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
    public partial class FrmModificarAdoptantes : Form
    {
        public FrmModificarAdoptantes()
        {
            InitializeComponent();
            cmbGeneroAdoptante.Items.Add("Hombre");
            cmbGeneroAdoptante.Items.Add("Mujer");
            cmbGeneroAdoptante.Items.Add("Otro");
        }

        private void btnBuscarAdoptante_Click(object sender, EventArgs e)
        {
            int idAdoptanteABuscar;
            if (int.TryParse(txtIdAdoptanteBuscar.Text, out idAdoptanteABuscar))
            {
                ClsAdoptantes adoptanteEncontrado = ClsGestionArchivos.BuscarAdoptantePorID(idAdoptanteABuscar);

                if (adoptanteEncontrado != null)
                {
                    // Limpia el DataGridView y agrega el animal encontrado como único elemento.
                    dgvAdoptantes2.Rows.Clear();
                    dgvAdoptantes2.Rows.Add(adoptanteEncontrado.Idadoptante, adoptanteEncontrado.Dni,  adoptanteEncontrado.Nombres, adoptanteEncontrado.Apellidos, adoptanteEncontrado.Direccion, adoptanteEncontrado.Edad, adoptanteEncontrado.Genero, adoptanteEncontrado.Telefono);

                    // También puedes limpiar los campos de edición en el formulario.
                    //LimpiarCamposEdicion();
                }
                else
                {
                    MessageBox.Show("Animal no encontrado con ese IDanimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("IDanimal no válido. Por favor, ingrese un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarCambiosAdoptante_Click(object sender, EventArgs e)
        {
            int idAdoptanteAModificar;
            if (int.TryParse(txtIdAdoptanteBuscar.Text, out idAdoptanteAModificar))
            {
                ClsAdoptantes adoptanteEncontrado = ClsGestionArchivos.BuscarAdoptantePorID(idAdoptanteAModificar);

                if (adoptanteEncontrado != null)
                {
                    // Actualiza los valores del animal con los nuevos valores proporcionados por el usuario
                    adoptanteEncontrado.Dni = int.Parse(txtDni.Text);
                    adoptanteEncontrado.Nombres = txtNombres.Text;
                    adoptanteEncontrado.Apellidos = txtApellidos.Text;
                    adoptanteEncontrado.Direccion = txtDireccion.Text;
                    adoptanteEncontrado.Edad = int.Parse(txtEdad.Text);
                    adoptanteEncontrado.Genero = cmbGeneroAdoptante.SelectedItem.ToString();
                    adoptanteEncontrado.Telefono = int.Parse(txtTelefono.Text);

                    // Actualiza el archivo de texto con los nuevos valores
                    ClsGestionArchivos.ActualizarAdoptanteEnArchivo(adoptanteEncontrado);

                    MessageBox.Show("Se guardo exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("No se encontro ningun resultado con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ID no válido. Por favor, ingrese un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarAdoptante_Click(object sender, EventArgs e)
        {
            if (dgvAdoptantes2.SelectedCells.Count > 0)
            {
                int rowIndex = dgvAdoptantes2.SelectedCells[0].RowIndex; // Obtiene el índice de la fila seleccionada
                int idAdoptanteAEliminar = (int)dgvAdoptantes2.Rows[rowIndex].Cells["Column1"].Value;

                if (MessageBox.Show("¿Estás seguro de que deseas eliminar este adoptante?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ClsGestionArchivos.EliminarAdoptantePorID(idAdoptanteAEliminar);

                    
                    

                    // Actualiza el DataGridView para reflejar la eliminación.
                    dgvAdoptantes2.Rows.RemoveAt(rowIndex);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una celda o fila del DataGridView para eliminar un adoptante.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
