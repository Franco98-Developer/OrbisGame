using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrbisGame.Models
{
    public class UsuariosViewModel
    {
        public int IdUsuario { get; set; }
        public string NombreyApellido { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Mail { get; set; }
    }
}
