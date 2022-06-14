using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrbisGame.Models;
using OrbisGame.Entidades;
using OrbisGame.Services;

namespace Orbisgame.Controllers
{
    public class SecurityController : Controller
    {
        // GET: SecurityController
        public ActionResult Registro()
        {
            return View();
        }

        // POST: SecurityController/Registro
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registro(UsuariosViewModel newUser)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult PasswordRecovery()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PasswordRecovery(UsuariosViewModel usuariosViewModel)
        {
            try
            {
                //Instancia la clase para envio de Correo
                Email Correo = new Email();

                var user = new Usuarios()
                {

                    Mail = usuariosViewModel.Mail,
                };



                //Genere PIN aleatorio
                var randomGenerator = new Random();
                var randomPIN = randomGenerator.Next(10000, 10000000);


                //Prueba HARDCODING DE CONTRASEÑA
                //Correo.enviarCorreo(user.Mail,"jorge1234");

                //Instancio para ejecutar el cambio de contraseña
                var usuario = new Usuario();
                usuario.CambiarPassword(user.Mail, randomPIN);

                //Obtener el usuario para enviar correctamente el mensaje
                var nombredeUsuario = usuario.ObtenerUsuarioporMail(user.Mail);

                //Envia PIN ALEATORIO al correo ingresado
                Correo.enviarCorreoSobrecarga(nombredeUsuario.ToString(), randomPIN.ToString(), user.Mail);



                return View("PasswordRecovery");
            }
            catch
            {
                return View("PasswordRecovery");
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SecurityController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SecurityController/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: SecurityController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SecurityController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SecurityController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SecurityController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
