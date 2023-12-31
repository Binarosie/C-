﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class LightningToMicroUsbAdapter : ILightningPhone
    {
        private readonly MicroUsbPhone microUsbPhone;
        public LightningToMicroUsbAdapter(MicroUsbPhone phone)
        {
            this.microUsbPhone = phone;
        }
        public void Recharge()
        {
            microUsbPhone.Recharge();
        }
        public void UseLightning()
        {
            Console.WriteLine("Adapter converts Lightning signal to Micro USB.");
            microUsbPhone.UseMicroUsb();
        }
    }
}
