using DiaryWPF.Commands;
using HRProgramWPF.Models;
using HRProgramWPF.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HRProgramWPF.ViewModels
{
    public class DbSettingsViewModel : ViewModelBase
    {

        private bool _canClose;
        public DbSettingsViewModel(bool canCloseWindow)
        {
            _canClose = canCloseWindow;
            AcceptSettingsCommand = new RelayCommand(Accept);
            CloseSettingsCommand = new RelayCommand(Close);
            _connSettings = new DbConnectionSettings();
        }

        private DbConnectionSettings _connSettings;
        public DbConnectionSettings ConnSettings { 
            get
            {
                return _connSettings;
            }
            set
            {
                _connSettings = value;
                OnPropertyChanged();
            }
        }
        public ICommand CloseSettingsCommand { get; set; }  
        public ICommand AcceptSettingsCommand { get; set; }

        private void Close(object obj)
        {
            if (!_canClose) Application.Current.Shutdown();
            else
            {
                var window = (obj as Window);
                window.Close();
            }

        }

        private void Accept(object obj)
        {
            if (!_connSettings.isValid)
                return;

            Properties.Settings settings = Properties.Settings.Default;
            settings.ServerName = _connSettings.ServerName;
            settings.DbName = _connSettings.DbName;
            settings.Password = _connSettings.Password;
            settings.User = _connSettings.User;
            settings.ServerAddres = _connSettings.ServerAddres;
            settings.Save();
            //Process.Start(Application.ResourceAssembly.Location);
            //Application.Current.Shutdown();

            var window = (obj as Window);
            window.Close();
          
            Application.Current.Shutdown();
            Process.Start(Application.ResourceAssembly.Location);

        }

    }

   
}
