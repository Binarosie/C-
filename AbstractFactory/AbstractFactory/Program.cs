using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IComputerFactory pcFactory = new PCFactory();

            ComputerAssembler pcAssembler = new ComputerAssembler(pcFactory);
            pcAssembler.AssembleComputer();

            IComputerFactory workstationFactory = new WorkstationFactory();
            ComputerAssembler workstationAssembler = new ComputerAssembler(workstationFactory);
            workstationAssembler.AssembleComputer();
        }
    }
}
