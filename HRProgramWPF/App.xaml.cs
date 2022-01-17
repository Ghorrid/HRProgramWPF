﻿using HRProgramWPF.Views;
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

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            var metroWindow = Current.MainWindow as MetroWindow;
            metroWindow.ShowMessageAsync("Błąd", "Wystąpił nieoczekinany wyjątek. \n" + e.Exception.Message);
            e.Handled = true;
        }


        public App()
        {
            var logInWindow = new LogInWindow();
            logInWindow.ShowDialog();

            // MainWindow mainWindow = new MainWindow();
            // mainWindow.Show();
        }
    }
}
