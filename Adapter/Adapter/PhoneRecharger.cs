using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class PhoneRecharger
    {
        public void RechargeLightningPhone(ILightningPhone phone)
        {
            phone.UseLightning();
            phone.Recharge();
            Console.WriteLine("Phone is recharged.");
        }
    }
}
