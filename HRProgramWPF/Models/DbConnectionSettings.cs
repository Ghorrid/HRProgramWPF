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
        public string ServerAddres { get; set; }
        public string ServerName { get; set;}
        public string DbName { get; set; }
        public string User { get; set; } 
        public string Password { get; set; }
   
    }
}
