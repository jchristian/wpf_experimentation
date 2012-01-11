using System;
using System.Windows;

namespace UI
{
    class Startup
    {
        /// <summary>
        /// Application Entry Point.
        /// </summary>
        [STAThreadAttribute]
        public static void Main()
        {
            var mainWindow = new MainWindow();
            new Application().Run(mainWindow);
        }
    }
}
