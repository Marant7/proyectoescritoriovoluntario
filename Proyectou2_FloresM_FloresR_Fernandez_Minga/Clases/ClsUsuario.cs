using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectou2_FloresM_FloresR_Fernandez_Minga
{
    public class ClsUsuario
    {
        // Propiedades públicas que representan un usuario
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }

        // Constructor para crear instancias de usuarios
        public ClsUsuario(string nombreUsuario, string contraseña)
        {
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
        }

        
    }
}
