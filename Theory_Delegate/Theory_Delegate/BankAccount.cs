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
        private SendMessageDelagate reporter;

        public string FullName { get; set; }
        public int Sum { get; private set; } = 0;

        public void RegisterReporter(SendMessageDelagate sendMessageDelagate)
        {
            reporter += sendMessageDelagate;
        }
        public void UnRegisterDelegate(SendMessageDelagate sendMessageDelagate)
        {
            reporter -= sendMessageDelagate;            
        }

        public void AddSum(int sum)
        {          
            Sum += sum;
            reporter?.Invoke($"Vam nachisleno {sum}");
        }

        public int WithdrowSum(int sum)
        {
            if (sum <= Sum)
            {
                Sum -= sum;
                reporter?.Invoke($"U vas snyato {sum}");
                return sum;
            }
            reporter?.Invoke($"Malo babla {sum}");
            return -1;
        }


    }
}
