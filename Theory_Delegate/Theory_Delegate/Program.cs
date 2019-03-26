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
            //lamda expression
            account.ReportEvent += (text) => Console.WriteLine(text);

            var data = new List<string>
            {
                "Almaty",
                "Karaganda",
                "Nur-Sultan"
            };

            //withut lambda and syntaxSugar
            var bufferList = new List<string>();
            foreach(var cityName in data)
            {
                if (cityName.ToLower().Contains("t"))
                {
                    bufferList.Add(cityName);
                }
            }
            //lambda 
            var result = data.Where(cityName => cityName.ToLower().Contains("t"));

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
