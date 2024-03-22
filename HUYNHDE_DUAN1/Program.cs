using HUYNHDE_DUAN1.FormChildCotrols;
using HUYNHDE_DUAN1.FormUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HUYNHDE_DUAN1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new FormMain());
            Application.Run(new formLoginGrogram());
            // Application.Run(new formForgetPass());
            // Application.Run(new formChildManagerEmployee());
            //Application.Run(new formMessage());
            //Application.Run(new formChildTKCC());
            // Application.Run(new formMessageLogin());
            //Application.Run(new formChangesPass());
        }
    }
}
