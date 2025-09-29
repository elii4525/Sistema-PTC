using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.IO.Packaging;

namespace Modelos.ServiciosCorreoElectronico
{
    public abstract class Correo
    {

        private SmtpClient clienteSmtp;
        protected string remitente { get; set; }
        protected string contraseña { get; set; }
        protected string host { get; set; }
        protected int puerto { get; set; }
        protected bool habilitarSsl { get; set; }

        protected void initlizeSmtpClient()
        {
            clienteSmtp = new SmtpClient(host, puerto);
            clienteSmtp.Credentials = new NetworkCredential(remitente, contraseña);
            clienteSmtp.Host = host;
            clienteSmtp.Port = puerto;
            clienteSmtp.EnableSsl = habilitarSsl;
        }

        public void enviarCorreo(string subject, string body, List<string> recipientMail)
        { 
            var mensaje = new MailMessage();
            try
            {
                mensaje.From = new MailAddress(remitente);
                foreach (string mail in recipientMail)
                {
                    mensaje.To.Add(mail);
                }
                mensaje.Subject = subject;
                mensaje.Body = body;
                mensaje.Priority = MailPriority.Normal;
                clienteSmtp.Send(mensaje);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                mensaje.Dispose();
                clienteSmtp.Dispose();
            }
        }

    }
}
