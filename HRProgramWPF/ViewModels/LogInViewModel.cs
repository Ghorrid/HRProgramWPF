using DiaryWPF.Commands;
using HRProgramWPF.Models;
using HRProgramWPF.Views;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace HRProgramWPF.ViewModels
{
    public class LogInViewModel : ViewModelBase
    {
        private static readonly string _userLog = "admin";
        private static readonly string _passLog = "a";


        public LogInViewModel()
        {
            LogInCommand = new RelayCommand(LogIn);
            User = new User();
        }

        public ICommand LogInCommand { get; set; }

        private User _user;

        public User User
        {
            get { return _user; }
            set
            {
                _user = value;
                OnPropertyChanged();
            }
        }


        private void LogIn(object parameter)
        {
            var passwordBox = parameter as PasswordBox;
            var password = passwordBox.Password;
            var userName = User.UserName;
            if (userName == _userLog && password == _passLog)
            {
                if (CheckConnection())
                {
                    var mainWindow = new MainWindow();
                    mainWindow.ShowDialog();
                }
                else
                {
                    var messageWindow = new MessageWindow();
                    messageWindow.ShowDialog();
                }

            }
            else return;
        }
        public static bool CheckConnection()
        {
            using (var context = new ApplicationDbContext())
            {
                if (context.Database.Exists())
                    return true;
                else return false;
            }
        }
    }
}

