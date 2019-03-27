using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate
{
    public delegate void MyGenericDelegate<T>(T arg);
    class Program
    {       
        private static void StringData(string arg)
        {
            Console.WriteLine(arg.ToUpper());
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        static void DisplayMsg(string msg, ConsoleColor txtColor, int printCount)
        {
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;

            for(int i = 0; i < printCount; ++i)
            {
                Console.WriteLine(msg);
            }
            Console.ForegroundColor = previous;
        }

        static void Main(string[] args)
        {
            /*MyGenericDelegate<string> myGenericDelegate = new MyGenericDelegate<string>(StringData);
            myGenericDelegate("Some String Data");
            */

            Action<string, ConsoleColor, int> action = new Action<string, ConsoleColor, int>(DisplayMsg);
            action("HelloBaby", ConsoleColor.Blue, 6);

            Func<int, int, int> func = new Func<int, int, int>(Add);

            Console.WriteLine(func(3, 7));

            Console.ReadLine();
        }
    }
}
