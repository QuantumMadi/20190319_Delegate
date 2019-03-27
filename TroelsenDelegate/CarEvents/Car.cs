using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents
{
    public class Car
    {
        public delegate void CarEngineHandler(string msgForCaller);

        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;

        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }
        private bool carIsDead;
       
       
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
                Exploded("cascasdcsdcsd");
            }
            else
            {
                CurrentSpeed += delta;
                if (10==(MaxSpeed - CurrentSpeed) && AboutToBlow != null) { AboutToBlow("Careful buddy!"); }
                if (CurrentSpeed >= MaxSpeed) carIsDead = true;
                else Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}
