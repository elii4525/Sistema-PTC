using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Vistas.Helper
{
    public class FuenteHelper
    {

        // Para agregar la tipografia Epilogue, primero se descargo un paquete NuGet para tener el system.drawing.text 
        // PrivateFontCollection es parte de esta biblioteca y ayuda a que las fuentes que se quieran agregar por medio de un archivo se puedan agregar
        // El bool es para que se sepa que si se cargo la fuente y Obtener fuente es un metodo de hecho FuenteHelper es una clase 
        // El pfc.AddFontFile es el nombre de la variable que se ocupa para el privatefontcollection y luego se escribe la direccion d ela fuente (descargada en la compu)
        // Por ultimo la carga se vuelve verdadera y devuelve la fuente con la posibilidad de ir cambiando los tamaños en el windows form, por eso el float tamaño

        private static PrivateFontCollection pfc = new PrivateFontCollection();
        private static bool cargada = false;

        public static Font ObtenerFuente(float tamaño)
        {

            if(!cargada)
            {
                pfc.AddFontFile(@"Fonts/Epilogue-BlackItalic.ttf");
                cargada = true;
            }

            return new Font(pfc.Families[0], tamaño);

        }

        public static Font ObtenerFuente2(float tamaño)
        {

            if (!cargada)
            {
                pfc.AddFontFile(@"Fonts/Epilogue-ExtraBold.ttf");
                cargada = true;
            }

            return new Font(pfc.Families[0], tamaño);

        }

    }
}
