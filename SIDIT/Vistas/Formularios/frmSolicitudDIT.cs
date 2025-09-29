using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Entidades;
using Vistas.controles;

namespace Vistas.Formularios
{
    public partial class frmSolicitudDIT : Form
    {
        public frmSolicitudDIT()
        {
            InitializeComponent();
        }

        private void frmSolicitudDIT_Load(object sender, EventArgs e)
        {
            CargarSolicitudes();
        }

        // 🔹 Método reutilizable para cargar las últimas solicitudes del usuario en sesión
        private void CargarSolicitudes()
        {
            Label[] nombreUsuario1 = { lblNombre };
            Label[] rol1 = { lblRol };
            Label[] fecha1 = { lblFecha };
            Label[] motivo1 = { lblDescripcion };
            Label[] materiales1 = { lblMaterial1, lblMaterial2, lblMaterial3 };
            Label[] cantidades1 = { lblCantidad1, lblCantidad2, lblCantidad3 };
            Label[] marcas1 = { lblMarca1, lblMarca2, lblmarca3 };

            Label[] nombreUsuario2 = { lblNombre2 };
            Label[] rol2 = { lblRol2 };
            Label[] fecha2 = { lblFecha2 };
            Label[] motivo2 = { lblMotivo2 };
            Label[] materiales2 = { lblMaterial4, lblMaterial5, lblMaterial6 };
            Label[] cantidades2 = { lblCantidad4, lblCantidad5, lblCantidad6 };
            Label[] marcas2 = { lblMarca4, lblMarca5, lblMarca6 };

            Label[] nombreUsuario3 = { lblNombre3 };
            Label[] rol3 = { lblRol3 };
            Label[] fecha3 = { lblFecha3 };
            Label[] motivo3 = { lblMotivo3 };
            Label[] materiales3 = { lblMaterial7, lblMaterial8, lblMaterial9 };
            Label[] cantidades3 = { lblCantidad7, lblCantidad8, lblCantidad9 };
            Label[] marcas3 = { lblMarca7, lblMarca8, lblMarca9 };

            Label[][] nombreUsuarios = { nombreUsuario1, nombreUsuario2, nombreUsuario3 };
            Label[][] roles = { rol1, rol2, rol3 };
            Label[][] fechas = { fecha1, fecha2, fecha3 };
            Label[][] motivos = { motivo1, motivo2, motivo3 };
            Label[][] materiales = { materiales1, materiales2, materiales3 };
            Label[][] cantidades = { cantidades1, cantidades2, cantidades3 };
            Label[][] marcas = { marcas1, marcas2, marcas3 };

            int idUsuario = Usuario.SesionActual.IdUsuario;
            Solicitud sol = new Solicitud(nombreUsuarios, roles, fechas, motivos, materiales, cantidades, marcas);
            sol.CargarUltimasTresSolicitudesPorUsuario(idUsuario);
        }

        private void buttonRedondeado1_Click(object sender, EventArgs e)
        {
            int idUsuario = Usuario.SesionActual.IdUsuario;

            frmEnviarSolicitud uc = new frmEnviarSolicitud(idUsuario);
            FrmContenedorUC ven = new FrmContenedorUC(uc);

            if (ven.ShowDialog() == DialogResult.OK)
            {
                CargarSolicitudes();
            }
        }

        private void btnSolicitudesAnteriores_Click(object sender, EventArgs e)
        {
            int idUsuario = Usuario.SesionActual.IdUsuario;

            // Crear la nueva ventana pasando el idUsuario
            frmSolicitudesAnteriores frm = new frmSolicitudesAnteriores(idUsuario);

            // Mostrar como ventana emergente modal
            frm.ShowDialog();
        }

    }
}
