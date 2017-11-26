using Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankServices
{
    public class BankService
    {
        private BankBaseEntities db = new BankBaseEntities();

        public bool VerifyAccount(int accountNum, int pin)
        {
            var query = from a in db.Accounts
                        where a.AccountNumber == accountNum && a.PIN == pin
                        select a;
            foreach (var acct in query)
            {
                System.Console.WriteLine("Welcome to your account.");
                return true;
            }

            System.Console.WriteLine("Wrong account information");
            return false;
        }

        public void CreateAccount (int AccountNumber, int PIN)
        {
            using (var ctx = new BankBaseEntities())
            {
                var entity = new Account
                {
                    AccountNumber = AccountNumber,
                    PIN =PIN
                };
                ctx.Accounts.Add(entity);
                ctx.SaveChanges();
            }
        }

        public void Add_Account()
        {
            Console.WriteLine("Enter a 4-digit PIN");
            int pin = Console.ReadLine();


        }
    }
}
