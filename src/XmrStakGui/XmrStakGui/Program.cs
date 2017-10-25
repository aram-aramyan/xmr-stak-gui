using System;
using System.Threading;
using System.Windows.Forms;

namespace XmrStakGui
{
    internal static class Program
    {
        private static Mutex mutex = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            bool createdNew;
            mutex = new Mutex(true, "XmrStakGui", out createdNew);
            if (!createdNew)
            {
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}