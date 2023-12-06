using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonAbstract
{
    public class MacOSFactory : IGUIFactory
    {
    public IButton createButton()
    {
        return new MacOSButton();
    }
    public ICheckBox createCheckbox()
    {
        return new MacOSCheckbox();
    }
}
}
