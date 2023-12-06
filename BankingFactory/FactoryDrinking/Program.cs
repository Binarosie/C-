using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDrinking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IBankAccount tkCuaQuiin = CreateBankAccount.createBankAccount(100);
            tkCuaQuiin.LaiSuat(100);
            tkCuaQuiin.NapTien(99);
        }
    }
}
