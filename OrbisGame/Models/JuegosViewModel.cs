using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orbisgame.Models
{
    public class JuegosViewModel
    {
        public int Id_Juego { get; set; }
        public string Nom_Juego { get; set; }
        public string Categorias { get; set; }
        public string Precio { get; set; }
        public string Compatibilidad { get; set; }
    }
}
