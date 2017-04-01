using System;
using MetroFramework;
using System.Windows.Forms;

namespace Proyecto1Tiempos.Utils
{
    class Messages
    {

        public static void MensajeMediano(IWin32Window form,String title,String mensaje) {
            MetroMessageBox.Show(form, mensaje, title, 100);
        }
        public static void MensajePequeno(IWin32Window form, String mensaje)
        {
           MetroMessageBox.Show(form, "", mensaje, 70);
        }
    }
}
