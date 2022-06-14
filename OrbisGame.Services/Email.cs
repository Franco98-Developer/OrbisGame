using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;


namespace OrbisGame.Services
{
    public class Email
    {

        public void enviarCorreo(string usuario, string password)
        {

            var smtpClient = new SmtpClient("mail.orbisplay.ar")
            {
                Port = 587,
                Credentials = new NetworkCredential("recovery@orbisplay.ar", "K6QhaUp6tegN"),
                EnableSsl = true
            };


            //Envia
            //smtpClient.Send("emmanuel@orbisplay.ar", "eschonberger@schonberger.com.ar", "Prueba", "Hola mundo");


            //Para enviar mensaje multilinea
            var mensaje = "Usuario: " + usuario + " \n" +
                        "Contraseña: " + password + " \n";


            smtpClient.Send("recovery@orbisplay.ar", "eschonberger@schonberger.com.ar", "Recuperacion de Contraseña", mensaje);
        }



        public void enviarCorreoSobrecarga(string usuario, string password, string destino)
        {

            var smtpClient = new SmtpClient("mail.orbisplay.ar")
            {
                Port = 587,
                Credentials = new NetworkCredential("recovery@orbisplay.ar", "K6QhaUp6tegN"),
                EnableSsl = true
            };


            //Envia
            //smtpClient.Send("emmanuel@orbisplay.ar", "eschonberger@schonberger.com.ar", "Prueba", "Hola mundo");


            //Para enviar mensaje multilinea
            var mensaje = "Usuario: " + usuario + " \n" +
                        "Contraseña: " + password + " \n";


            smtpClient.Send("recovery@orbisplay.ar", destino, "Recuperacion de Contraseña", mensaje);
        }
    }


}