using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_EJERCICIO_11
{
    public class Cliente
    {
        public string nombreDeUsuario;
        public string Nombre;
        public string Apellido;
        public string Mail;

        //public List<> Pedidos;

        public Cliente (string nombreUsuario ,string nombre, string apellido, string mail)
        {
            nombreDeUsuario = nombreUsuario;
            Nombre = nombre;
            Apellido = apellido;
            Mail = mail;
        }
    }
}
