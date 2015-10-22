using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Squashids
{
    //userData user = new userData();
    static class Program
    //class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       public static userData user = new userData();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginForm());
            
        }
    }
}
