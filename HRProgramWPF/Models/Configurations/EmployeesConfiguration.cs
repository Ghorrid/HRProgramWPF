using HRProgramWPF.Models.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProgramWPF.Models.Configurations
{
    public class EmployeesConfiguration : EntityTypeConfiguration <Employee>
    {
        public EmployeesConfiguration()
        {
            ToTable("dbo.Employees");

            HasKey(x => x.Id);

            Property(x => x.Id).IsRequired();
            Property(x => x.FirstName).IsRequired().HasMaxLength(100);

            Property(x =>x.LastName).IsRequired().HasMaxLength(100);

            
        }
    }
}
