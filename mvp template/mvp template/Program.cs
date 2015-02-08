using System;
using System.Windows.Forms;

namespace mvp_template
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var applicationController = new ApplicationController();
            applicationController.RegisterView<IMainView, MainForm>();

            applicationController.Run<MainPresenter>();
        }
    }
}
