using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALC__
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
            telaPrincipalForm inicial = new telaPrincipalForm();
            inicial.Show();
            Application.DoEvents();            
            Thread.Sleep(2000);
            inicial.Dispose();
            Application.Run(new TelaPrincipal());
        }
    }
}
