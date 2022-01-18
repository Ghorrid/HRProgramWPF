using HRProgramWPF.Views;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HRProgramWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public App()
        {
            var logInWindow = new LogInWindow();
            logInWindow.Show();

            // MainWindow mainWindow = new MainWindow();
            // mainWindow.Show();
        }
    }
}
