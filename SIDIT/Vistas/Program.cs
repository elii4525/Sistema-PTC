using System;
using System.Windows.Forms;
using Vistas.Formularios;
using Modelos.Entidades;

namespace Vistas
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            using (frmPantallaCarga splash = new frmPantallaCarga())
            {
                splash.ShowDialog();
            }

            if (!Usuario.ExistenUsuarios())
            {
                using (frmPrimerUsuario frm = new frmPrimerUsuario())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new frmLogin());
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else
            {
                Application.Run(new frmLogin());
            }
        }
    }
}


