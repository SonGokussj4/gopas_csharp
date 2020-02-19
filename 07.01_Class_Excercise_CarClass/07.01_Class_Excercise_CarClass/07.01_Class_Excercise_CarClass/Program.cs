using System;
using System.Collections.Generic;

namespace _07._01_Class_Excercise_CarClass
{
    public class Car
    {
        public string Manufacturer;
        public string Name;
        private int Speed = 0;

        //Getter - Speed
        public int GetSpeed()
        {
            return this.Speed;
        }
        
        public void SpeedUp(int num=1)
        {
            this.Speed += num;
        }

        public void SpeedDown(int num=1)
        {
            this.Speed -= num;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car Octavia = new Car();
            Car Fabia = new Car();

            List<Car> Cars = new List<Car>
            {
                Octavia,
                Fabia
            };

            // Speedy car
            Octavia.Manufacturer = "Skoda";
            Octavia.Name = "Octavia";
            //Octavia.Speed = 0;

            Octavia.SpeedUp();
            Octavia.SpeedUp(4);
            Octavia.SpeedUp();

            // Sluggish car
            Fabia.Manufacturer = "Skoda";
            Fabia.Name = "Fabia";
            //Fabia.Speed = 0;

            Fabia.SpeedDown();
            Fabia.SpeedDown(3);

            foreach (Car item in Cars)
            {
                Console.WriteLine("Car: '{0}' has speed: '{1}'", item.Name, item.GetSpeed());
            }
        }
    }
}
