using IsKaiser.Management.WinUI.Forms;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace IsKaiser.Management.WinUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread.CurrentThread.CurrentCulture =
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("tr-TR");
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Visual Studio 2013 Light";
            Application.Run(new frmLogin());
        }
    }
}
