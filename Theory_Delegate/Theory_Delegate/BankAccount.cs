using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory_Delegate
{
    public class BankAccount
    {
        public string FullName { get; set; }
        public int Sum { get; private set; } = 0;
        public IReporter Reporter { get; private set; }

        public BankAccount(IReporter reporterCallBack)
        {
            Reporter = reporterCallBack;
        }

        public void AddSum(int sum)
        {          
            Sum += sum;
            if(Reporter!=null)
                Reporter.SendMessage($"Vam nachisleno {sum}");
        }

        public int WithdrowSum(int sum)
        {
            if (sum <= Sum)
            {
                Sum -= sum;
                if (Reporter != null)
                    Reporter.SendMessage($"U vas snyato {sum}");
                return sum;
            }
            if (Reporter != null)
                Reporter.SendMessage($"Malo babla {sum}");
            return -1;
        }
    }
}
