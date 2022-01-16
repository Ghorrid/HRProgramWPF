using HRProgramWPF.Models.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProgramWPF
{
    public class Repository
    {
       public List<Employees> GetEmployees()
        {
            using (var context = new ApplicationDbContext())
            {
                var employees = new List<Employees>();
                employees = context.Employees.ToList();
                return employees;
            }
        }

        public void FireEmpolyee(Employees SelectedEmployee)
        {
            using (var context = new ApplicationDbContext())
            {
                var empolyeeToFire = context.Employees.Find(SelectedEmployee.Id);
                if (empolyeeToFire != null)
                {
                    empolyeeToFire.DateOfDismissal = DateTime.Now;
                }
                context.SaveChanges();                
            }

        }

        public void AddNewEmployee (Employees employee)
        {
            using (var context = new ApplicationDbContext())
            {
                if (employee == null)
                    return;
                context.Employees.Add(employee);
                context.SaveChanges();
            }
        }

        public void EdidEmployee (Employees employee)
        {
            using(var context = new ApplicationDbContext())
            {
                var employeeFromDb = context.Employees.Where(x=>x.Id == employee.Id).FirstOrDefault();
                employeeFromDb.Id = employee.Id;
                employeeFromDb.FirstName = employee.FirstName;
                employeeFromDb.LastName = employee.LastName;
                employeeFromDb.Comments = employee.Comments;
                employeeFromDb.EmpolyeeNumber = employee.EmpolyeeNumber;
                employeeFromDb.DateOfEmpolyement = employee.DateOfEmpolyement;
                employeeFromDb.Wages = employee.Wages;
                context.SaveChanges();
            }
        }

    }
}
