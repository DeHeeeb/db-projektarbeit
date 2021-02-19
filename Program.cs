using db_projektarbeit.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using db_projektarbeit.Model;
using Microsoft.EntityFrameworkCore;

namespace db_projektarbeit
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ProjectContext context = new ProjectContext();
            context.Database.Migrate();
            Application.Run(new Home());
        }
    }
}
