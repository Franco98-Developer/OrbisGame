using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Orbisgame.Models;
using System.Diagnostics;
using OrbisGame.Services;
using OrbisGame.Models;
using OrbisGame.Entidades;
using System.Collections.Generic;
using System;

namespace Orbisgame.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        Seguridad seguridad = new Seguridad();

        Juego game = new Juego();

        Usuario users = new Usuario();

        

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserName") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Inicio");
            }
        }

        public IActionResult Inicio()
        {
            return View();
        }

        public IActionResult Tarjeta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Inicio(string Usuario, string clave)
        {
            var validUser = seguridad.Login(Usuario, clave);
            if (validUser != null)
            {
                HttpContext.Session.SetString("UserName", validUser.NombreyApellido.ToString());
                HttpContext.Session.SetString("UserId", validUser.IdUsuario.ToString());
                return RedirectToAction("MainUser");
            }
            else
            {
                
                ViewBag.ErrorLog = "Usuario o Contraseña Incorrectas";
                return View("Inicio");
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registro(UsuariosViewModel usuariosViewModel)
        {
            try
            {
                var user = new Usuarios()
                {
                    NombreyApellido = usuariosViewModel.NombreyApellido,
                    Usuario = usuariosViewModel.Usuario,
                    Mail = usuariosViewModel.Mail,
                    Contraseña = usuariosViewModel.Contraseña

                };
                users.Registro(user);
                return View("Inicio");
            }
            catch
            {
                return View("Inicio");
            }
        }

        public IActionResult AltaJuego()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AltaJuego(JuegosViewModel juegosViewModel)
        {
            try
            {
                var juego = new Juegos()
                {
                    Nom_Juego=juegosViewModel.Nom_Juego,
                    Categorias=juegosViewModel.Categorias,
                    Compatibilidad=juegosViewModel.Compatibilidad,
                    Precio=juegosViewModel.Precio
                };
                game.RegistroJuego(juego);
                return View("AltaJuego");
            }
            catch
            {
                return View("AltaJuego");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Catalogo(int idJuego)
        {

            try
            {
                game.DescargarJuego(int.Parse(HttpContext.Session.GetString("UserId")), idJuego);
                return View("Tarjeta");
                



            }
            catch (Exception ex)
            {
                
                return View("Inicio");
            }


            return RedirectToAction("Descargas");
        }

        //public IActionResult BuscarporNombre(string valor)
        //{
        //    var CatalogoJuegos = game.SearchbyGameName("Nom_Juego", valor);



        //    List<JuegosViewModel> juegoview = new List<JuegosViewModel>();

        //    foreach (Juegos juego in CatalogoJuegos)
        //    {
        //        juegoview.Add(new JuegosViewModel()
        //        {
        //            Id_Juego = juego.Id_Juego,
        //            Nom_Juego = juego.Nom_Juego,
        //            Categorias = juego.Categorias,
        //            Compatibilidad = juego.Compatibilidad,
        //            Precio = juego.Precio
        //        });
                
        //    }
        //    return View(juegoview);


        //}

        public IActionResult Catalogo()
        {
            var CatalogoJuegos = game.GetAllGame();

            List<JuegosViewModel> juegoview = new List<JuegosViewModel>();

            foreach (Juegos juego in CatalogoJuegos)
            {
                juegoview.Add(new JuegosViewModel()
                {
                    Id_Juego = juego.Id_Juego,
                    Nom_Juego = juego.Nom_Juego,
                    Categorias = juego.Categorias,
                    Compatibilidad = juego.Compatibilidad,
                    Precio = juego.Precio
                });
            }

            return View(juegoview);
        }

        [HttpGet]
        public IActionResult Catalogo(string nombre)
        {
            try
            {
                var CatalogoJuegos = game.SearchbyGameName("Nom_Juego", nombre);


                List<JuegosViewModel> juegoview = new List<JuegosViewModel>();

                foreach (Juegos juego in CatalogoJuegos)
                {
                    juegoview.Add(new JuegosViewModel()
                    {
                        Id_Juego = juego.Id_Juego,
                        Nom_Juego = juego.Nom_Juego,
                        Categorias = juego.Categorias,
                        Compatibilidad = juego.Compatibilidad,
                        Precio = juego.Precio
                    });
                }
                return View(juegoview);
            }
            catch (Exception ex)
            {

                return View("Inicio");
            }
            return RedirectToAction("Catalogo");
        }
        
        public IActionResult Descargas() 
        {
           
            var JuegosDescargados = game.GetAllDescargas(HttpContext.Session.GetString("UserId"));

            
            List<JuegosViewModel> juegosViews = new List<JuegosViewModel>();
            foreach (Juegos download in JuegosDescargados)
            {
                juegosViews.Add(new JuegosViewModel()
                {
                    Nom_Juego=download.Nom_Juego,
                    Categorias=download.Categorias,
                    Compatibilidad=download.Compatibilidad
                    
                });
            }

            return View(juegosViews);
           
        }

        public IActionResult AdminLogin()
        {
            return View();
        }
        

        [HttpPost]
        public IActionResult AdminLogin(string Admin, string Contraseña)
        {

            var validAdmin = seguridad.LogeoAdmin(Admin, Contraseña);
            if (validAdmin != null)
            {
                HttpContext.Session.SetString("UserName", Admin);
                return RedirectToAction("MainAdmin");
            }
            else
            {
                ViewBag.ErrorLog = "Usuario o Contraseña Incorrectas";
                return View("AdminLogin");
            }
        }

        public IActionResult Productos()
        {
            return View();
        }

        public IActionResult Descuento()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Descuento(UsuariosViewModel usuariosViewModel)
        {
            try
            {
                //Instancia la clase para envio de Correo
                Email Correo = new Email();

                var user = new Usuarios()
                {

                    Mail = usuariosViewModel.Mail,
                };

                var usuario = new Usuario();
                //Obtener el usuario para enviar correctamente el mensaje
                var nombredeUsuario = usuario.ObtenerUsuarioporMail(user.Mail);
                //Envia PIN ALEATORIO al correo ingresado
                Correo.enviarCorreoNovedades(nombredeUsuario.ToString(),user.Mail);


                return View("MainUser");

            }
            catch(Exception ex)
            {
                return View("Descuento");
            }
        }

        public IActionResult UsuariosActivos()
        {
            var UserActive = users.GetAllUsers();

            List<UsuariosViewModel> userView = new List<UsuariosViewModel>();

            foreach (Usuarios user in UserActive)
            {
                userView.Add(new UsuariosViewModel()
                {
                    IdUsuario = user.IdUsuario,
                    NombreyApellido = user.NombreyApellido,
                    Usuario = user.Usuario,
                    Mail = user.Mail,
                    Contraseña = user.Contraseña
                });
            }

            return View(userView);
        }

        [HttpPost]
        public IActionResult UsuariosActivos(int idUser)
        {
            users.eliminarUsuario(idUser);
            return RedirectToAction(nameof(UsuariosActivos));
        }

        public IActionResult Juegos()
        {
            return View();
        }

        public IActionResult MainUser()
        {
            return View();
        }

        public IActionResult MainAdmin()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
