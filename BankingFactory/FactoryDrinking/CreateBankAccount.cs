using NSubstitute.ReceivedExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDrinking
{
    public class CreateBankAccount
    {
        public static IBankAccount createBankAccount(double money)
        {
            IBankAccount account = null;
            if (money <= 0)
            {
                Console.WriteLine("Tao tai khoan that bai");
            }
            else
            {
                account = new BankAccount(money);
            }
            return account;
        }
    }
}
