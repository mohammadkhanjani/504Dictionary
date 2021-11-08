using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace Dictionary
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.

        static Mutex mutex = new Mutex(true, "{39d5e2c9-8791-4f77-a1f4-d0e81f1b1681}");


        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("در حال حاضر یک نمونه از برنامه در حال اجرا می باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            
        }
    }
}
