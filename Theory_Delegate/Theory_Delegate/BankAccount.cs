using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory_Delegate
{
    public delegate void SendMessageDelagate(string message);  
    public class BankAccount
    {
        public event SendMessageDelagate ReportEvent;

        public string FullName { get; set; }
        public int Sum { get; private set; } = 0;
     

        public void AddSum(int sum)
        {          
            Sum += sum;
            ReportEvent?.Invoke($"Vam nachisleno {sum}");
        }

        public int WithdrowSum(int sum)
        {
            if (sum <= Sum)
            {
                Sum -= sum;
                ReportEvent?.Invoke($"U vas snyato {sum}");
                return sum;
            }
            ReportEvent?.Invoke($"Malo babla {sum}");
            return -1;
        }


    }
}
