using System;
using System.Windows.Forms;
using Vega.UI;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if NETCOREAPP3_1 || NET5_0 || NET6_0
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
#endif

            Control.CheckForIllegalCrossThreadCalls = false;
            Application.Run(new Loading());
        }
    }
}