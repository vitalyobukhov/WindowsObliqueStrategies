using System;
using System.Windows.Forms;
using ObliqueStrategies.Forms;

namespace ObliqueStrategies.Classes
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
