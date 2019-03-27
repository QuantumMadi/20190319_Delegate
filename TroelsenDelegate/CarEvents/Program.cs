using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Car.CarEngineHandler engineHandler = new Car.CarEngineHandler(SomeMethod); // передача метода как параметр конструктора
            car.Exploded += engineHandler;  //регестрация метода подпсика на событие
            car.Exploded += delegate { Console.WriteLine("HellBoy"); };
            car.Exploded += delegate (string innerString) {  Console.WriteLine(innerString + "Fuck this  chit"); };
            
            
            for (int i = 0; i < 6; ++i)
            {
                car.Accelerate(20);
            }

            Console.ReadLine();
        }

       

        private static void SomeMethod(string msgForCaller)
        {
            Console.WriteLine(msgForCaller.ToUpper());
        }
    }
}
