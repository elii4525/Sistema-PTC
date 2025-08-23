using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Vistas.HelperBarraNegra
{
    internal static class BarraNegra
    {

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE_OLD = 19;
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        [DllImport("dwmapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        public static bool TryApplyDarkTitleBar(IntPtr handle)
        {
            try
            {
                int useDark = 1;


                if (DwmSetWindowAttribute(handle, DWMWA_USE_IMMERSIVE_DARK_MODE, ref useDark, sizeof(int)) == 0)
                    return true;

                if (DwmSetWindowAttribute(handle, DWMWA_USE_IMMERSIVE_DARK_MODE_OLD, ref useDark, sizeof(int)) == 0)
                    return true;
            }
            catch (DllNotFoundException) { }  
            catch (EntryPointNotFoundException) { }  
            return false;
        }
    }

}

