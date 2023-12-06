using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    public class Developer : Employee, ICode
    {
        private Coder codePart;
        public Developer(string name) : base(name)
        {
            codePart = new Coder();
        }
        public override void PerformDuties()
        {
            codePart.WriteCode();
        }
        public void WriteCode()
        {
            codePart.WriteCode();
        }
    }
}
