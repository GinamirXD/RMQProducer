using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Producer
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string savedLang = LocalizationManager.GetSavedLanguage();
            Thread.CurrentThread.CurrentCulture = new CultureInfo(savedLang);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(savedLang);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
