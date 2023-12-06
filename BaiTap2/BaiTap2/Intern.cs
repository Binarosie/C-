using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BaiTap2
{
    public class Intern : Employee
    {
        public Intern(string name) : base(name) { }
        public override void PerformDuties()
        {
            Console.WriteLine($"{Name} is assitting with simpler tasks.");
        }
    }
}
