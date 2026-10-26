using Fayl_meneceri;
using System;
using System.Windows.Forms;

namespace Fayl_meneceri
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Bu sətrlər yazçıların və formun bulanıq qalmasının qarşısını alır (High DPI)
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form1());
        }
    }
}