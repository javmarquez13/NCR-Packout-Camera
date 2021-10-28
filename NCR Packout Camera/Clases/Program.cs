using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace NCR_Packout_Camera
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
			//Application.Run(new CameraSetting());
			
            //bool AlreadyExists = false;
            //System.Threading.Mutex appStart = new System.Threading.Mutex(true, Application.ProductName, out AlreadyExists);
            //if (!AlreadyExists)
            //{
            //    MessageBox.Show("Una instancia de la misma aplicacion esta en ejecucion");
            //    Environment.Exit(0);
            //}

            Application.Run(new MainForm());
        }
    }
}
