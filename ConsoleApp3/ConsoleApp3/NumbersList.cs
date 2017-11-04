using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class NumbersList
    {
        public List<int> numbers = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19
            };
        public void GetSumOfEvenNumbers()
        {
            IEnumerable<int> evens = from i in numbers where i % 2 == 0 select i;
            int Sum = 0;
            foreach (int s in evens)
            {
                Sum = Sum + s;                
            }
            Console.WriteLine(Sum);
        }
        
    }
}
