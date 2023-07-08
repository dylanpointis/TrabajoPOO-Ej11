using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_EJERCICIO_11.Clases
{
    public class Usuario
    {
        public string nombreDeUsuario;
        public string Clave;
        public string Nombre;
        public string Apellido;
        public string Mail;
        public string Rol;

        public Usuario(string nombreUsuario, string clave,string nombre, string apellido, string mail, string rol)
        {
            nombreDeUsuario = nombreUsuario;
            Clave = clave;
            Nombre = nombre;
            Apellido = apellido;
            Mail = mail;
            Rol = rol;
        }
    }
}
