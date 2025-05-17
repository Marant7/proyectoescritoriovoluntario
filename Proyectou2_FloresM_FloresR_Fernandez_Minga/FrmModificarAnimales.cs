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
    public partial class FrmModificarAnimales : Form
    {
        public FrmModificarAnimales()
        {
            InitializeComponent();
            cmbGenero.Items.Add("Macho");
            cmbGenero.Items.Add("Hembra");
        }
        
        private void btnBuscarAnimal_Click(object sender, EventArgs e)
        {

            int idAnimalABuscar;
            if (int.TryParse(txtIdAnimalBuscar.Text, out idAnimalABuscar))
            {
                ClsAnimales animalEncontrado = ClsGestionArchivos.BuscarAnimalPorID(idAnimalABuscar);

                if (animalEncontrado != null)
                {
                    // Limpia el DataGridView y agrega el animal encontrado como único elemento.
                    dgvAnimales2.Rows.Clear();
                    dgvAnimales2.Rows.Add(animalEncontrado.IdAnimal, animalEncontrado.Nombre, animalEncontrado.Especie, animalEncontrado.Raza, animalEncontrado.Edad, animalEncontrado.Genero, animalEncontrado.HistorialMedico);

                    
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

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            int idAnimalAModificar;
            if (int.TryParse(txtIdAnimalBuscar.Text, out idAnimalAModificar))
            {
                ClsAnimales animalEncontrado = ClsGestionArchivos.BuscarAnimalPorID(idAnimalAModificar);

                if (animalEncontrado != null)
                {
                    // Actualiza los valores del animal con los nuevos valores proporcionados por el usuario
                    animalEncontrado.Nombre = txtNombre.Text;
                    animalEncontrado.Especie = txtEspecie.Text;
                    animalEncontrado.Raza = txtRaza.Text;
                    animalEncontrado.Edad = int.Parse(txtEdad.Text);
                    animalEncontrado.Genero = cmbGenero.SelectedItem.ToString();
                    animalEncontrado.HistorialMedico = txtHistorialMedico.Text;

                    // Actualiza el archivo de texto con los nuevos valores
                    ClsGestionArchivos.ActualizarAnimalEnArchivo(animalEncontrado);

                    // También puedes actualizar la lista de animales (si la tienes) con los nuevos valores.

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

        private void btnEliminarAnimal_Click(object sender, EventArgs e)
        {
            if (dgvAnimales2.SelectedCells.Count > 0)
            {
                int rowIndex = dgvAnimales2.SelectedCells[0].RowIndex; // Obtiene el índice de la fila seleccionada
                int idAnimalAEliminar = (int)dgvAnimales2.Rows[rowIndex].Cells["Column1"].Value;

                if (MessageBox.Show("¿Estás seguro de que deseas eliminar este adoptante?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ClsGestionArchivos.EliminarAnimalPorID(idAnimalAEliminar);

                    // Si tienes una lista, elimina el animal de la lista también.
                   

                    // Actualiza el DataGridView para reflejar la eliminación.
                    dgvAnimales2.Rows.RemoveAt(rowIndex);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una celda o fila del DataGridView para eliminar un animal.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
