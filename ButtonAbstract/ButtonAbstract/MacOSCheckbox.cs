using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonAbstract
{
    public class MacOSCheckbox : ICheckBox
    {
    public void paint()
    {
       Console.WriteLine("You have created MacOSCheckbox.");
    }
}
}
