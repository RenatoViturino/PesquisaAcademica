using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pesquisa_com_Watson
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var programDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            Gecko.Xpcom.Initialize("xulrunner/");
           // Gecko.XpCom.Initialize(Path.Combine(programDirectory, "xulrunner"));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }
    }
}
