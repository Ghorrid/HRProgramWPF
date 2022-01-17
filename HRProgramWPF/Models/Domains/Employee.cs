using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProgramWPF.Models.Domains
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmpolyeeNumber { get; set; }
        public DateTime? DateOfEmpolyement { get; set; }
        public DateTime? DateOfDismissal { get; set; }
        public string Comments { get; set; }
        public decimal Wages { get; set; }
    }
}
