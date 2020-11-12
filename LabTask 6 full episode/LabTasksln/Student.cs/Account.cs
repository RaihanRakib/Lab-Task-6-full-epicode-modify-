using System;
using System.Collections.Generic;
using System.Text;

namespace Student.cs
{
    class Account
    {
        String accName;
        String acid;
        int balance;
        private Account()
        { }
        public Account(String an,String ai,int bl)
        {
            accName = an;
            acid = ai;
            balance = bl;
        }
        void ShowAc()
        {
            Console.WriteLine("Your account Info: ");
            Console.WriteLine("Account Name: " + accName);
            Console.WriteLine("Account ID: " + acid);
            Console.WriteLine("Account Balance: " + balance);
        }
    }
}
