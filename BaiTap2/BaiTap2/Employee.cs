using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    public abstract class Employee : IWorkable
    {
        public string Name { get; set; }
        protected Employee(string name)
        {
            Name = name;
        }
        public abstract void PerformDuties();
    }
}
