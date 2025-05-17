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
using System.IO;
using System.Security.Cryptography;

namespace Proyectou2_FloresM_FloresR_Fernandez_Minga
{
    public partial class FormGestionAnimales : Form
    {
        private ClsAnimales nuevoAnimal;

        public FormGestionAnimales()
        {
            InitializeComponent();

            cmbGenero.Items.Add("Macho");
            cmbGenero.Items.Add("Hembra");
        }
        
        private void btnRegistrarAnimal_Click(object sender, EventArgs e)
        {

            int idAnimal = int.Parse(txtIdAnimal.Text);
            if (ClsGestionArchivos.ExisteAnimalConID(idAnimal))
            {
                MessageBox.Show("Ya existe un animal con este ID. Por favor, elija otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            //int idAnimal = int.Parse(txtIdAnimal.Text);
            string nombre = txtNombre.Text;
            string especie = txtEspecie.Text;
            string raza = txtRaza.Text;
            int edad = int.Parse(txtEdad.Text);
            string genero = cmbGenero.SelectedItem.ToString();
            string historialMedico = txtHistorialMedico.Text;
            byte[] foto = ObtenerBytesDeImagen(); 

            nuevoAnimal = new ClsAnimales(idAnimal, nombre, especie, raza, edad, genero, historialMedico, foto);
            ClsGestionArchivos.AgregarAnimal(nuevoAnimal);
                MessageBox.Show("Fue Registrado exitosamente", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private byte[] ObtenerBytesDeImagen()
        {
            if (pictureBoxImagen.Image == null)
            {
                return null; // No hay imagen en el PictureBox
            }

            using (MemoryStream stream = new MemoryStream())
            {
                pictureBoxImagen.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg); // Formato de imagen

                return stream.ToArray();
            }
        }

        private void btnActualizarAnimal_Click(object sender, EventArgs e)
        {
            FrmModificarAnimales formModificar = new FrmModificarAnimales();
            formModificar.ShowDialog();
        }

        private void btnEliminarAnimal_Click(object sender, EventArgs e)
        {
           
        }
        

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            // Abre el cuadro de diálogo para seleccionar un archivo de imagen
            openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.png;*.jpeg;*.gif;*.bmp|Todos los archivos|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Carga la imagen seleccionada en el control PictureBox
                pictureBoxImagen.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
