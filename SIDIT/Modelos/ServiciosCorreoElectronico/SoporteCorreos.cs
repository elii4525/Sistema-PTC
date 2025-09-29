using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.ServiciosCorreoElectronico
{
    class SoporteCorreos:Correo
    {

        public SoporteCorreos()
        {
            remitente = "itecavisos@gmail.com";
            contraseña = "Contrasena123";
            host = "smtp.gmail.com";
            puerto = 587;
            habilitarSsl = true;
            initlizeSmtpClient();
        }

    }
}
