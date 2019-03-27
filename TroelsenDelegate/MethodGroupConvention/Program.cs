using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodGroupConvention
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.RegisterWithCarEngine(CallMeHere);
            for (int i = 0; i < 6; ++i)
            {
                car.Accelerate(20);
            }
            Console.ReadLine();
        }

        public static void CallMeHere(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
