using Microsoft.AspNetCore.Mvc;
using OrbisGame.Entidades;

//Para la API
using OrbisGame.Entidades.DTOs;
using OrbisGame.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrbisAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JuegosController : ControllerBase
    {

        //Instanciar Listas juegos descargados
        Juego test = new Juego();

        // GET: api/<JuegosController>
        [HttpGet]
        public IEnumerable<JuegosDTO> Get()
        {

            var ListaJuegos = test.GetAllGame();
            List<JuegosDTO> listaJuegosDTO = new List<JuegosDTO>();
            foreach (var juego in ListaJuegos)
            {
                listaJuegosDTO.Add(new JuegosDTO()
                {
                    Nom_Juego = juego.Nom_Juego,
                    Categorias = juego.Categorias,
                    Precio = juego.Precio,
                    Compatibilidad = juego.Compatibilidad,

                }
                    );

            }



            return listaJuegosDTO;
        }

        // GET api/<JuegosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<JuegosController>
        [HttpPost]
        public void Post(JuegosDTO nuevoJuego)
        {
            var NuevoJuego = new Juegos()
            {
                Nom_Juego = nuevoJuego.Nom_Juego,
                Categorias = nuevoJuego.Categorias,
                Compatibilidad = nuevoJuego.Compatibilidad,
                Precio = nuevoJuego.Precio


            };



            //Registrar Juego - tomando desde la instanciacion de la linea 18
            test.RegistroJuego(NuevoJuego);


        }

        // PUT api/<JuegosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<JuegosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}