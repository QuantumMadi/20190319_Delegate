﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount(new ConsoleReporter())
            {
                FullName = "Petrovich"
            };

            account.AddSum(1000);
            account.WithdrowSum(100);
            Console.ReadLine();
        }
    }
}
