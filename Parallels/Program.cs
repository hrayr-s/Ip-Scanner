using System;
using System.Windows.Forms;

namespace TaskApp
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Parallels.Input_Details());
        }
    }
}