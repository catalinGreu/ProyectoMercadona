﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;
using MerCadona.App_Code.Modelos;

namespace MerCadona.App_Code.Controladores
{
    public class ControladorEmail
    {
        private string __subject = "Sugerencias mercadona";
        private string __subject2 = "Confirmacion pago";
        private string __from = "mercadonashop@outlook.es";
        private string __host = "smtp-mail.outlook.com";
        public ControladorEmail() { }
        public ControladorEmail(string to)
        {
            string message = "Estimado usuario:\n"
                              + "Este correo se le ha enviado como respuesta a su peticion"
                              + " de recordatorio de password.\n"
                              + "Su usuario es: " + to + "\n"
                              + " Acceda al siguiente enclace para cambiar su contraseña: \n"
                              + "http://localhost:2243/AyudaConfirmarPass.aspx?email=" + to;

            SmtpClient cliente = new SmtpClient();
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.UseDefaultCredentials = false;
            cliente.Host = __host;
            cliente.Port = 587;
            cliente.Credentials = new NetworkCredential(__from, "mercadona_shopPr0yect");//passwd
            cliente.EnableSsl = true;

            try
            {
                MailMessage correo = new MailMessage();
                correo.From = new MailAddress(__from);
                correo.To.Add(to);
                correo.Subject = __subject;
                correo.Body = message;

                cliente.Send(correo);
            }
            catch (Exception e)
            {
                e.ToString();
                return;
            }

        }

        public void sendFactura( Cliente c, string total, string cuenta )
        {
            string message = "Estimado usuario:\n"
                              + "le enviamos el correo "
                              + " de confirmacion de compra "
                              + "Que se enviará a la direccion: \n"
                              + c.Direccion + "\n"
                              + "Por un total de: " + total
                              + "al numero de cuenta " + cuenta;

            SmtpClient cliente = new SmtpClient();
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.UseDefaultCredentials = false;
            cliente.Host = __host;
            cliente.Port = 587;
            cliente.Credentials = new NetworkCredential(__from, "mercadona_shopPr0yect");//passwd
            cliente.EnableSsl = true;

            try
            {
                MailMessage correo = new MailMessage();
                correo.From = new MailAddress(__from);
                correo.To.Add(c.Email);
                correo.Subject = __subject2;
                correo.Body = message;

                cliente.Send(correo);
            }
            catch (Exception e)
            {
                e.ToString();
                return;
            }

        }


    }
}