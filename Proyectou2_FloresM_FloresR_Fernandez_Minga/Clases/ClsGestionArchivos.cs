using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectou2_FloresM_FloresR_Fernandez_Minga.Clases
{
    public class ClsGestionArchivos
    {
        // Ruta del archivo de usuarios y contraseñas
        private string rutaArchivo = "C:\\GestorArchivos\\Usuarios.txt"; // Ruta del archivo de usuarios y contraseñas

        // Método para autenticar un usuario
        public bool AutenticarUsuario(string nombreUsuario, string contraseña)
        {
            //// Lee el archivo de usuarios y contraseñas
            //string[] lineas = File.ReadAllLines(rutaArchivo);

            //foreach (string linea in lineas)
            //{
            //    string[] partes = linea.Split(';');

            //    if (partes.Length == 2)
            //    {
            //        string usuario = partes[0];
            //        string pass = partes[1];

            //        if (usuario == nombreUsuario && pass == contraseña)
            //        {
            //            return true; // Las credenciales son correctas
            //        }
            //    }
            //}

            //return false; // No se encontró una coincidencia
            return nombreUsuario == "admin" && contraseña == "admin123";

        }
        // Métodos relacionados con la gestión de animales
        public static void AgregarAnimal(ClsAnimales animal)
        { // Código para agregar un animal a un archivo
            string rutaArchivo = @"C:\GestorArchivos\animales.txt";
            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                string linea = $"{animal.IdAnimal},{animal.Nombre},{animal.Especie},{animal.Raza},{animal.Edad},{animal.Genero},{animal.HistorialMedico}";
                writer.WriteLine(linea);
            }
        }
        public static List<ClsAnimales> ObtenerAnimales()
        {
            // Código para obtener una lista de animales desde un archivo
            string rutaArchivo = @"C:\GestorArchivos\animales.txt";
            List<ClsAnimales> animales = new List<ClsAnimales>();

            if (File.Exists(rutaArchivo))
            {
                string[] lines = File.ReadAllLines(rutaArchivo);

                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    if (data.Length == 7)
                    {
                        int idAnimal = int.Parse(data[0]);
                        string nombre = data[1];
                        string especie = data[2];
                        string raza = data[3];
                        int edad = int.Parse(data[4]);
                        string genero = data[5];
                        string historialMedico = data[6];
                        byte[] foto = null; // Implementa la lógica para obtener la imagen si la estás almacenando.

                        ClsAnimales animal = new ClsAnimales(idAnimal, nombre, especie, raza, edad, genero, historialMedico, foto);
                        animales.Add(animal);
                    }
                }
            }

            return animales;
        }

        public static ClsAnimales BuscarAnimalPorID(int id)
        {
            // Código para buscar un animal por su ID en un archivo
            string rutaArchivo = @"C:\GestorArchivos\animales.txt";
            string[] lineas = File.ReadAllLines(rutaArchivo);

            foreach (string linea in lineas)
            {
                string[] partes = linea.Split(',');
                if (partes.Length == 7) // Asumiendo que hay 7 campos por línea en el archivo
                {
                    int idAnimal = int.Parse(partes[0]);
                    if (idAnimal == id)
                    {
                        // Se encontró el animal con el IDanimal especificado
                        string nombre = partes[1];
                        string especie = partes[2];
                        string raza = partes[3];
                        int edad = int.Parse(partes[4]);
                        string genero = partes[5];
                        string historialMedico = partes[6];
                        byte[] foto = null; // Obtén la imagen si la estás almacenando.

                        return new ClsAnimales(idAnimal, nombre, especie, raza, edad, genero, historialMedico, foto);
                    }
                }
            }

            return null; // No se encontró un animal con ese IDanimal en el archivo
        }

        public static void ActualizarAnimalEnArchivo(ClsAnimales animalActualizado)
        {
            // Código para actualizar un animal en un archivo
            string rutaArchivo = @"C:\GestorArchivos\animales.txt";
            string[] lineas = File.ReadAllLines(rutaArchivo);
            List<string> lineasActualizadas = new List<string>();

            foreach (string linea in lineas)
            {
                string[] partes = linea.Split(',');
                if (partes.Length == 7)
                {
                    int idAnimal = int.Parse(partes[0]);
                    if (idAnimal == animalActualizado.IdAnimal)
                    {
                        // Si se encuentra el animal a actualizar, reemplaza la línea con los nuevos datos.
                        string nuevaLinea = $"{animalActualizado.IdAnimal},{animalActualizado.Nombre},{animalActualizado.Especie},{animalActualizado.Raza},{animalActualizado.Edad},{animalActualizado.Genero},{animalActualizado.HistorialMedico}";
                        lineasActualizadas.Add(nuevaLinea);
                    }
                    else
                    {
                        // Si no es el animal a actualizar, agrega la línea original.
                        lineasActualizadas.Add(linea);
                    }
                }
            }

            // Escribe las líneas actualizadas en el archivo.
            File.WriteAllLines(rutaArchivo, lineasActualizadas);
        }
        public static void EliminarAnimalPorID(int idAnimalAEliminar)
        {
            // Código para eliminar un animal por su ID en un archivo
            string rutaArchivo = @"C:\GestorArchivos\animales.txt";
            string[] lineas = File.ReadAllLines(rutaArchivo);
            List<string> lineasActualizadas = new List<string>();

            foreach (string linea in lineas)
            {
                string[] partes = linea.Split(',');
                if (partes.Length == 7)
                {
                    int idAnimal = int.Parse(partes[0]);
                    if (idAnimal != idAnimalAEliminar)
                    {
                        // Si no es el animal a eliminar, agrega la línea original.
                        lineasActualizadas.Add(linea);
                    }
                }
            }

            // Escribe las líneas actualizadas en el archivo para eliminar el animal.
            File.WriteAllLines(rutaArchivo, lineasActualizadas);
        }



        //aqui
        public static bool ExisteAnimalConID(int idAnimal)
        {
            // Código para verificar si un animal con el ID especificado existe en un archivo
            string rutaArchivo = @"C:\GestorArchivos\animales.txt";

            if (File.Exists(rutaArchivo))
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);
                foreach (string linea in lineas)
                {
                    string[] partes = linea.Split(',');
                    if (partes.Length == 7)
                    {
                        int id = int.Parse(partes[0]);
                        if (id == idAnimal)
                        {
                            return true; // El IDanimal ya existe.
                        }
                    }
                }
            }

            return false; // El IDanimal no existe.
        }


        // Métodos relacionados con la gestión de adoptantes

        public static bool ExisteAdoptanteConID(int idAdoptante)
        {
            // Código para verificar si un adoptante con el ID especificado existe en un archivo
            string rutaArchivo = @"C:\GestorArchivos\adoptante.txt";

            if (File.Exists(rutaArchivo))
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);
                foreach (string linea in lineas)
                {
                    string[] partes = linea.Split(',');
                    if (partes.Length == 8)
                    {
                        int id = int.Parse(partes[0]);
                        if (id == idAdoptante)
                        {
                            return true; 
                        }
                    }
                }
            }

            return false; 
        }

        public static void AgregarAdoptante(ClsAdoptantes adoptante)
        {// Código para agregar un adoptante a un archivo
            string rutaArchivo = @"C:\GestorArchivos\adoptante.txt";
            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                string linea = $"{adoptante.Idadoptante},{adoptante.Dni},{adoptante.Nombres},{adoptante.Apellidos},{adoptante.Direccion},{adoptante.Edad},{adoptante.Genero},{adoptante.Telefono}";
                writer.WriteLine(linea);
            }
        }
        public static List<ClsAdoptantes> ObtenerAdoptantes()
        {
            // Código para obtener una lista de adoptantes desde un archivo
            string rutaArchivo = @"C:\GestorArchivos\adoptante.txt";
            List<ClsAdoptantes> Adoptantes = new List<ClsAdoptantes>();

            if (File.Exists(rutaArchivo))
            {
                string[] lines = File.ReadAllLines(rutaArchivo);

                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    if (data.Length == 8)
                    {
                 
                        int idAdoptante = int.Parse(data[0]);
                        int dni = int.Parse(data[1]);
                        string nombres = data[2];
                        string apellidos = data[3];
                        string direccion = data[4];
                        int edad = int.Parse(data[5]);
                        string genero = data[6];
                    
                        int telefono = int.Parse(data[7]);
                       

                        ClsAdoptantes adoptante = new ClsAdoptantes(idAdoptante,dni,nombres,apellidos,direccion,edad,genero , telefono);
                        Adoptantes.Add(adoptante);
                    }
                }
            }

            return Adoptantes;
        }

        public static ClsAdoptantes BuscarAdoptantePorID(int id)
        {
            // Código para buscar un adoptante por su ID en un archivo
            string rutaArchivo = @"C:\GestorArchivos\adoptante.txt";
            string[] lineas = File.ReadAllLines(rutaArchivo);

            foreach (string linea in lineas)
            {
                string[] partes = linea.Split(',');
                if (partes.Length == 8) // Asumiendo que hay 7 campos por línea en el archivo
                {
                    int idAdoptante = int.Parse(partes[0]);
                    if (idAdoptante == id)
                    {
                        // Se encontró el adoptante con el idAdoptante especificado
                        //int idAdoptante = int.Parse(partes[0]);
                        int dni = int.Parse(partes[1]);
                        string nombres = partes[2];
                        string apellidos = partes[3];
                        string direccion = partes[4];
                        int edad = int.Parse(partes[5]);
                        string genero = partes[6];
                        int telefono = int.Parse(partes[7]);

                        return new ClsAdoptantes(idAdoptante, dni, nombres, apellidos, direccion, edad, genero, telefono);
                    }
                }
            }

            return null;
        }

        public static void ActualizarAdoptanteEnArchivo(ClsAdoptantes adoptanteActualizado)
        {
            // Código para actualizar un adoptante en un archivo
            string rutaArchivo = @"C:\GestorArchivos\adoptante.txt";
            string[] lineas = File.ReadAllLines(rutaArchivo);
            List<string> lineasActualizadas = new List<string>();

            foreach (string linea in lineas)
            {
                string[] partes = linea.Split(',');
                if (partes.Length == 8)
                {
                    int idAdoptante = int.Parse(partes[0]);
                    if (idAdoptante == adoptanteActualizado.Idadoptante)
                    {
                        // Si se encuentra el adoptante a actualizar, reemplaza la línea con los nuevos datos.
                        string nuevaLinea = $"{adoptanteActualizado.Idadoptante},{adoptanteActualizado.Dni},{adoptanteActualizado.Nombres},{adoptanteActualizado.Apellidos},{adoptanteActualizado.Direccion},{adoptanteActualizado.Edad},{adoptanteActualizado.Genero},{adoptanteActualizado.Telefono}";
                        lineasActualizadas.Add(nuevaLinea);
                    }
                    else
                    {
                        // Si no es el adoptante a actualizar, agrega la línea original.
                        lineasActualizadas.Add(linea);
                    }
                }
            }

            // Escribe las líneas actualizadas en el archivo.
            File.WriteAllLines(rutaArchivo, lineasActualizadas);
        }
        public static void EliminarAdoptantePorID(int idAdoptanteAEliminar)
        {
            // Código para eliminar un adoptante por su ID en un archivo
            string rutaArchivo = @"C:\GestorArchivos\adoptante.txt";
            string[] lineas = File.ReadAllLines(rutaArchivo);
            List<string> lineasActualizadas = new List<string>();

            foreach (string linea in lineas)
            {
                string[] partes = linea.Split(',');
                if (partes.Length == 8)
                {
                    int idAdoptante = int.Parse(partes[0]);
                    if (idAdoptante != idAdoptanteAEliminar)
                    {
                        // Si no es el adoptante a eliminar, agrega la línea original.
                        lineasActualizadas.Add(linea);
                    }
                }
            }

            // Escribe las líneas actualizadas en el archivo para eliminar el adoptante.
            File.WriteAllLines(rutaArchivo, lineasActualizadas);
        }
    }
}

