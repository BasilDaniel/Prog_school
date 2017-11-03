using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var CarsList = new List<Cars>
            {
                new Car1(),                
                new Car2()               
            };
            foreach (var Cars in CarsList)
            {
                Cars.GetYourCarGeneralInfo();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

}
