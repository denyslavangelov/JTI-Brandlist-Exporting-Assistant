using System;
using Brandlist_Export_Assistant.Forms;

namespace Brandlist_Export_Assistant
{
    public static class Engine
    {
        [STAThread]
        public static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new MainUI());
        }
    }
}
