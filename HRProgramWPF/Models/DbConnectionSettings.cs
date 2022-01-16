using HRProgramWPF.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProgramWPF.Models
{
    public class DbConnectionSettings
    {
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

    }
}
