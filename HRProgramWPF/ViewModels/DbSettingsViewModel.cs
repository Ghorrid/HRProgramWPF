using DiaryWPF.Commands;
using HRProgramWPF.Models;
using HRProgramWPF.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HRProgramWPF.ViewModels
{
    public class DbSettingsViewModel : ViewModelBase
    {


        public DbSettingsViewModel()
        {

            AcceptSettingsCommand = new RelayCommand(Accept);
            CloseSettingsCommand = new RelayCommand(Close);
        }

        public ICommand CloseSettingsCommand { get; set; }  
        public ICommand AcceptSettingsCommand { get; set; }

        private void Close(object obj)
        {
            var window = (obj as Window);
            window.Close();
        }

        private void Accept(object obj)
        {
            throw new NotImplementedException();
        }

    }

   
}
