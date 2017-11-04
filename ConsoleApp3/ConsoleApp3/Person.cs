using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Person
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public int Rating { get; set; }

        public Person(string SecondName, string FirstName, string MiddleName, int Age, string Position, int Salary, int Rating) //Person construtor
        {
            this.SecondName = SecondName;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.Age = Age;
            this.Position = Position;
            this.Salary = Salary;
            this.Rating = Rating;
        }
    }
}
