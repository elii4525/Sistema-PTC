using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class frmListaInventario : UserControl
    {
        public frmListaInventario()
        {
            InitializeComponent();
        }

        bool expand = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                pnlMenuPlegable.Height += 15;
                if (pnlMenuPlegable.Height >= pnlMenuPlegable.MaximumSize.Height)
                {
                    timerMenuPleg.Stop();
                    expand = true;
                }

            }
            else
            {
                pnlMenuPlegable.Height -= 15;
                if (pnlMenuPlegable.Height <= pnlMenuPlegable.MinimumSize.Height)
                {
                    timerMenuPleg.Stop();
                    expand = false;
                }
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            timerMenuPleg.Start();
        }
    }
}
