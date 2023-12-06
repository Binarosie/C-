using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class PCFactory : IComputerFactory
    {
        public ICPU CreateCPU()
        {
            return new PCCPU();
        }
        public IGPU CreateGPU()
        {
            return new PCGPU();
        }
    }
}
