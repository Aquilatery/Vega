using System;
using System.Windows.Forms;

namespace Vega
{
    internal static class Vega
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
#if NETCOREAPP3_1 || NET5_0 || NET6_0
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
#endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Loading());
        }
    }
}