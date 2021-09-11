using System;
using System.Threading;
using System.Windows.Forms;

namespace Pixmatter
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            string guid = "4c8ef235-81b8-4d67-b15e-454d4d8bb915";
            using Mutex mutex = new Mutex(false, "Global\\" + guid);
            if (!mutex.WaitOne(0, false))
            {
                return;
            }

            ProgramEntry();
        }

        private static void ProgramEntry()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppForm());
        }
    }
}
