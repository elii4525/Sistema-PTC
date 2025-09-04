using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas.Formularios;

namespace Vistas
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogin());
<<<<<<< HEAD
            //Application.Run(new frmBienvenidaJefatura());
            Application.Run(new frmSalidaMaterialDIT());
=======
            Application.Run(new frmMenuDIT());
>>>>>>> 93caa384b70863a1d8f6817cf56269b4824c3795
        }
    }
}
