using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    public class Company
    {
        private List<Employee> employees;
        public Company()
        {
            employees = new List<Employee>();
        }
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public void StartWorkDay()
        {
            foreach (var employee in employees)
            {
                employee.PerformDuties();
            }
        }
    }
}
