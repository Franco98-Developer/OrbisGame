using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using MimeKit;
using System.IO;

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

            //Para enviar mensaje multilinea
            var mensaje = "Usuario: " + usuario + " \n" +
                        "Contraseña: " + password + " \n";


            smtpClient.Send("recovery@orbisplay.ar", destino, "Recuperacion de Contraseña", mensaje);
        }

        public bool enviarCorreoNovedades(string usuario, string destino)
        {
            bool Result = false;
            try
            {
                string Body = GetTemplate(usuario, destino);
                var smtpclient = new SmtpClient("mail.orbisplay.ar")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("novedades@orbisplay.ar", "iFgZHQ/5Xa"),
                    EnableSsl = true
                };
               

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(destino);
                mail.To.Add(destino);
                mail.Subject = "Envio de Novedades";
                mail.Body = Body;
                mail.IsBodyHtml = true;

                smtpclient.Send(mail);
                Result = true;

            }
            catch (Exception ex)
            {
                Result = false;
            }
            return Result;
        }

        public string GetTemplate(string usuario, string destino)
        {
            string Mailtext = string.Empty;
            string FilePath = Directory.GetCurrentDirectory() + "\\Templates\\Template.html";
            StreamReader str = new StreamReader(FilePath);
            Mailtext = str.ReadToEnd();
            str.Close();
            Mailtext = Mailtext.Replace("[username]", usuario);

            return Mailtext;
        }

    }
}