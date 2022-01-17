using HRProgramWPF.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProgramWPF.Models
{
    public class DbConnectionSettings : IDataErrorInfo
    {


        private bool _isServerAddresValid;
        private bool _isServerNameValid;
        private bool _isDbNameValid;
        private bool _isUserValid;
        private bool _isPasswordValid;
        

        public string ServerAddres {
            get
            { 
                return Settings.Default.ServerAddres; 
            }
            set 
            {
                Settings.Default.ServerAddres = value;
            }
        }
        public string ServerName
        {
            get
            {
                return Settings.Default.ServerName;
            }
            set
            {
                Settings.Default.ServerName = value;
            }
        }
        public string DbName
        {
            get
            {
                return Settings.Default.DbName;
            }
            set
            {
                Settings.Default.DbName = value;
            }
        }
        public string User
        {
            get
            {
                return Settings.Default.User;
            }
            set
            {
                Settings.Default.User = value;
            }
        }
        public string Password
        {
            get
            {
                return Settings.Default.Password;
            }
            set
            {
                Settings.Default.Password = value;
            }
        }

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case nameof(ServerAddres):
                        if (string.IsNullOrWhiteSpace(ServerAddres))
                        {
                            _isServerAddresValid = false;
                            Error = "Pole jest ServerAddres  wymagane";
                        }
                        else
                        {
                            Error = string.Empty;
                            _isServerAddresValid = true;
                        }
                        break;
                    case nameof(ServerName):
                        if (string.IsNullOrWhiteSpace(ServerName))
                        {
                            Error = "Pole jest ServerName  wymagane";
                            _isServerNameValid = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isServerNameValid = true;
                        }
                            break;
                    case nameof(DbName):
                        if (string.IsNullOrWhiteSpace(DbName))
                        {
                            Error = "Pole jest DbName wymagane";
                            _isDbNameValid = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isDbNameValid = true;
                        }
                            break;
                    case nameof(User):
                        if (string.IsNullOrWhiteSpace(User))
                        {
                            Error = "Pole jest User wymagane";
                            _isUserValid = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isUserValid = true;
                        }
                            break;
                    case nameof(Password):
                        if (string.IsNullOrWhiteSpace(Password))
                        {
                            Error = "Pole jest Password wymagane";
                            _isPasswordValid = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isPasswordValid = true;
                        }
                            break;
                        default:
                        break;
                }
                return Error;
            }             
        }

        public bool isValid { get
            {
                return _isPasswordValid && _isUserValid && _isDbNameValid && _isServerAddresValid && _isServerNameValid;
            }
            }
        public string Error {get; set;}


    }
}
