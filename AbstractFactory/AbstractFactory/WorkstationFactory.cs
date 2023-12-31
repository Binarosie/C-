﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class WorkstationFactory : IComputerFactory
    {
        public ICPU CreateCPU()
        {
            return new WorkstationCPU();
        }
        public IGPU CreateGPU()
        {
            return new WorkstationGPU();
        }
    }
}
