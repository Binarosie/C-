using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MicroUsbPhone androi = new MicroUsbPhone();

            ILightningPhone adapter = new LightningToMicroUsbAdapter(androi);

            PhoneRecharger recharger = new PhoneRecharger();
            recharger.RechargeLightningPhone(adapter);
        }
    }
}
