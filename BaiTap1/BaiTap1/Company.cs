using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    public class Company
    {
        private List<IEmployee> employees;
        public Company()
        {
            employees = new List<IEmployee>();
        }
        public void AddEmployee(IEmployee employee)
        {
            employees.Add(employee);
        }
        public void StartWorkDay()
        {
            foreach (var employee in employees)
            {
                employee.Work();
                if (employee is Manager manager)
                {
                    manager.Manage();
                }
            }
        }
    }
}
