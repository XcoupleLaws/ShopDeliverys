using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using View.Presenters;

namespace View
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new MainMenuView();
            var presenter = new MainPresenter(mainForm, new UnitOfWork(new ShopContext()));

            Application.Run(mainForm);
        }
    }
}