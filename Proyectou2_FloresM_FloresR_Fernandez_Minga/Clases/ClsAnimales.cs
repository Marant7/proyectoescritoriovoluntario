using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectou2_FloresM_FloresR_Fernandez_Minga.Clases
{
    // Definición de la clase ClsAnimales
    public class ClsAnimales
    {
        // Propiedades públicas que representan las características de un animal

        public int IdAnimal { get; set; }// Identificador del animal
        public string Nombre { get; set; }// Nombre del animal
        public string Especie { get; set; } // Especie a la que pertenece el animal
        public string Raza { get; set; }// Raza del animal
        public int Edad { get; set; }// Edad del animal
        public string Genero { get; set; } // Género del animal
        public string HistorialMedico { get; set; } // Información médica del animal
        public byte[] Foto { get; set; } // Puedes usar byte[] para almacenar la imagen

        // Constructor de la clase ClsAnimales que inicializa las propiedades
        public ClsAnimales(int idAnimal,string nombre, string especie, string raza, int edad, string genero, string historialMedico, byte[] foto)
        {
            // Asigna los valores pasados como argumentos a las propiedades de la clase
            IdAnimal = idAnimal;
            Nombre = nombre;
            Especie = especie;
            Raza = raza;
            Edad = edad;
            Genero = genero;
            HistorialMedico = historialMedico;
            Foto = foto;
        }
    }
}
