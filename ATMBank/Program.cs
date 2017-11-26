using BankServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMBank
{
    class Program
    {

        static void Main(string[] args)
        {
            BankService authService = new BankService();
            Console.WriteLine("Enter a Account Number");
            var accountNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your PIN");
            var pin = Int32.Parse(Console.ReadLine());
            authService.VerifyAccount(accountNum, pin);
        }
         
    }
}
