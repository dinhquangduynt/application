using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationTextOff
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main(string[] args)
        {
            Thread thr = new Thread(() =>
            {
                UserActivityHook.HookKeyboard();

            }
            );
            thr.SetApartmentState(ApartmentState.STA);
            thr.IsBackground = true;
            thr.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Application.Run(new Form1());
        }
    }
}
