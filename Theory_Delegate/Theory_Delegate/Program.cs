using System;
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
            
            var account = new BankAccount
            {
                FullName = "Petrovich"
            };

            var reporter = new ConsoleReporter();
            account.ReportEvent  += reporter.SendMessage;
            account.ReportEvent += BlahBlah;

            //анонимный метод
            account.ReportEvent += delegate (string text) {
                /*
                 * какое-то тело
                 */
                return; };

            account.AddSum(1000);
            account.WithdrowSum(100);

            Console.ReadLine();
        }

        private static void BlahBlah(string message)
        {
            throw new NotImplementedException();
        }
    }
}
