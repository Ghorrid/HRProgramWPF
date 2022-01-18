using DiaryWPF.Commands;
using HRProgramWPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HRProgramWPF.ViewModels
{
    public class MessageWindowViewModel : ViewModelBase
    {

        public MessageWindowViewModel()
        {
            CloseSettingsCommand = new RelayCommand(CloseSettings);
            AcceptSettingsCommand = new RelayCommand(AcceptSettings);
        }
        private void AcceptSettings(object obj)
        {
            var dbConfigurationWindow = new DbSettings(false);
            dbConfigurationWindow.Show();
        }
        private void CloseSettings(object obj)
        {
            Application.Current.Shutdown();
        }
        public ICommand CloseSettingsCommand { get; set; }
        public ICommand AcceptSettingsCommand { get; set; }
    }


}
