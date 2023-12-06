﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class WorkstationGPU : IGPU
    {
        public void Render()
        {
            Console.WriteLine("Rendering high-quality graphics using Workstation GPU.");
        }
    }
}
