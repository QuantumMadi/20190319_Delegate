using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TroelsenDelegate
{
    public class Car
    {
        public delegate void CarEngineHandler(string msgForCaller);
        private CarEngineHandler listOfHandlers;
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }
        private bool carIsDead;
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers += methodToCall;
        }
        public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers -= methodToCall;
        }
        public Car() { MaxSpeed = 100; }
        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }
        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                listOfHandlers?.Invoke("Sorry, broo");
            }
            else
            {
                CurrentSpeed += delta;
                if (10==(MaxSpeed - CurrentSpeed) && listOfHandlers != null) { listOfHandlers.Invoke("Careful buddy!"); }
                if (CurrentSpeed >= MaxSpeed) carIsDead = true;
                else Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}
