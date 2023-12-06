using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDrinking
{
    public class BankAccount : IBankAccount
    {
        private double money;
        public BankAccount(double money)
        {
            this.money += money;
        }
        public void LaiSuat(double money)
        {
            if ( this.money > 0)
            {
                if (this.money <= 25000)
                {
                    money *= 0.05;
                    Console.WriteLine("The cua ban la Titanium");
                    Console.WriteLine("So lai suat ban nhan duoc: " + money + " nghin dong moi thang");
                }
                else if (this.money > 25000)
                {
                    money *= 0.1;
                    Console.WriteLine("The cua ban la Platinum");
                    Console.WriteLine("So lai suat ban nhan duoc: " + money + " nghin dong moi thang");
                }    
            }
            else
            {
                Console.WriteLine("So du trong tai khoan cua ban khong du!!!");
            }
        }
        public void NapTien(double money)
        {
            if (this.money <= 0)
            {
                Console.WriteLine("Am roi, nap thoiiii");
            }
            else
            {
                Console.WriteLine("Ban nap them: " + money + " nghin dong");
                this.money += money;
                Console.WriteLine("Tai khoan cua ban hien tai la: " + this.money + " nghin dong");
            }
        }
    }
}
