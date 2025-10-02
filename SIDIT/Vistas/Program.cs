using System;
using System.Windows.Forms;
using Vistas.Formularios;
using Modelos.Entidades;

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
            // Esto es para validar si existen usuarios en la base de datos
            if (!Usuario.ExistenUsuarios())
            {
                frmPrimerUsuario frm = new frmPrimerUsuario();

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new frmLogin());
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                // Si ya existen usuarios en la bd, ir directo al login
                Application.Run(new frmLogin());
            }

        }
    }
}

