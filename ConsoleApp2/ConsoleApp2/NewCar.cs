using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Car1 : Cars
    {
        public Car1()
        {
            Brand = "BMW";
            Model = "X6";
            FormFactor = "SUV";
            Wheels = 22;
            Doors = 5;
        }
    }
    public class Car2 : Cars
    {
        public Car2()
        {
            Brand = "LADA";
            Model = "2109";
            FormFactor = "Hatchback";
            Wheels = 13;
            Doors = 5;
        }
        public override void GetYourCarGeneralInfo()
        {
            Console.WriteLine($"Your Brand is- {Brand}");
            Console.WriteLine($"Your Model is- {Model}");
            Console.WriteLine($"Your car has FormFactor - {FormFactor}");
            Console.WriteLine($"Your car has Wheels size - {Wheels}");
            Console.WriteLine($"Your car has number of Doors - {Doors}");
        }
    }
}  
