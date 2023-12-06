using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonAbstract
{

    public class Application
    {
        private IButton button;
        private ICheckBox checkbox;

        public Application(IGUIFactory factory)
        {
            button = factory.createButton();
            checkbox = factory.createCheckbox();
        }

        public void paint()
        {
            button.paint();
            checkbox.paint();
        }
    }
}
