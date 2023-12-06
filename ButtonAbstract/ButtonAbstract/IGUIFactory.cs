﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonAbstract
{

    public interface IGUIFactory
    {
        IButton createButton();
        ICheckBox createCheckbox();
    }
}
