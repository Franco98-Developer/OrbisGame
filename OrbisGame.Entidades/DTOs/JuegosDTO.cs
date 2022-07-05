using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OrbisGame.Entidades.DTOs
{
    public class JuegosDTO
    {
        //Comentado - si luego es necesario para las descargas
        //public int Id_Juego { get; set; }
        public string Nom_Juego { get; set; }
        public string Categorias { get; set; }
        public string Precio { get; set; }
        public string Compatibilidad { get; set; }
    }
}
