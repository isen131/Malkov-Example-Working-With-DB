using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Прога_для_работы_с_БД
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Главная_форма());
        }
    }
}
