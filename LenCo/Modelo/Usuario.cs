using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenCo
{
    public static class Usuario
    {
        public static int idUsuario;
        public static string usuario;
        public static string password;
        public static int idRol;

        public static int pIdUsuario { get => idUsuario; set => idUsuario = value; }
        public static string pUsuario { get => usuario; set => usuario = value; }
        public static string pPassword { get => password; set => password = value; }

        public static int pIdRol { get => idRol; set => idRol = value; }
    }
}
