using System;
using System.Collections.Generic;
using System.Text;

namespace LabTask
{
    class Account
    {
        Account receiver;
        String accName;
        String acid;
        int balance = 0;
        private Account()
        { }
        public Account(String an, String ai, int bl)
        {
            accName = an;
            acid = ai;
            balance = bl;
        }

        public int deposite(int dep)
        {
            balance = balance + dep;
            return balance;
        }
        public int withdrow(int wd)
        {
            balance = balance - wd;
            return balance;
        }
        public void Transfer(int tk, Account receiver)
        {
            if (tk <= balance)
            {
                balance =balance- tk;
                receiver.balance = tk + balance; 
            }
            else
            { Console.WriteLine("Not sufficient balance");
            }
        }
        public void ShowBlance()
        {
            
            Console.WriteLine("Your Account Blance is: " + balance);
        }
        public void ShowAc()
        {
            Console.WriteLine("Your account Info: ");
            Console.WriteLine("Account Name: " + accName);
            Console.WriteLine("Account ID: " + acid);
            Console.WriteLine("Account Balance: " + balance);
        }
    }
}
