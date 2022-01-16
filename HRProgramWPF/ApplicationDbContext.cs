using HRProgramWPF.Models.Configurations;
using HRProgramWPF.Models.Domains;
using HRProgramWPF.Properties;
using HRProgramWPF.ViewModels;
using System;
using System.Data.Entity;
using System.Linq;

namespace HRProgramWPF
{
    public class ApplicationDbContext : DbContext
    {



        private  static  string _connectionString = $@"Server = ({Settings.Default.ServerAddres})\{Settings.Default.ServerName};
            Database = {Settings.Default.DbName}; User Id={Settings.Default.User};Password={Settings.Default.Password};";

        public ApplicationDbContext()
            : base(_connectionString)
        {
        }

       public  DbSet <Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeesConfiguration());
        }
    }

    
}