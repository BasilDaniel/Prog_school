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
            Wheels = 17;
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
    }
}  
