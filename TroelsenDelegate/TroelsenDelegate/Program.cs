using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TroelsenDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("SlugBug", 100, 10);

            Car.CarEngineHandler first = 
                new Car.CarEngineHandler(OnCarEngineEvent);          
            car.RegisterWithCarEngine(first);


            car.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent2));                     

            for (int i = 0; i < 6; ++i)
            {
                car.Accelerate(20);              
            }

           car.UnRegisterWithCarEngine(first);


          
            Console.ReadLine();
        }

        private static void OnCarEngineEvent2(string msgForCaller)
        {
            Console.WriteLine(msgForCaller.ToUpper()); 
        }

        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine(msg);
        }
        
    }
}
