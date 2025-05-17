using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectou2_FloresM_FloresR_Fernandez_Minga.Clases
{
    // Definición de la clase ClsAdoptantes
    public class ClsAdoptantes
    {
        // Propiedades públicas que representan las características de un adoptante
        public int Idadoptante { get; set; } // Identificador del adoptante
        public int Dni { get; set; }// Número de documento de identidad
        public string Nombres { get; set; }// Nombres del adoptante
        public string Apellidos { get; set; }// Apellidos del adoptante
        public string Direccion { get; set; }// Dirección del adoptante
        public int Edad { get; set; } // Edad del adoptante
        public string Genero { get; set; }// Género del adoptante
        public int Telefono { get; set; }// Número de teléfono del adoptante

        // Constructor de la clase ClsAdoptantes que inicializa las propiedades
        public ClsAdoptantes(int idAdoptante,int dni, string nombres, string apellidos, string direccion, int edad, string genero, int telefono)
        {
            // Asigna los valores pasados como argumentos a las propiedades de la clase
            Idadoptante = idAdoptante;
            Dni = dni;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Edad = edad;
            Genero = genero;
            Telefono = telefono;

        }
    }
}
