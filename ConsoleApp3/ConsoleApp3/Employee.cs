using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Employee
    {
        public List<Person> EmployeesList = new List<Person> {}; //Employees collection

        public void AddNewEmployeeToList(string SecondName, string FirstName, string MiddleName, int Age, string Position, int Salary, int Rating)
        {
            Person NewEmployee = new Person(SecondName, FirstName, MiddleName, Age, Position, Salary, Rating);
            EmployeesList.Add(NewEmployee);
        }
        public void ConsoleEmployeesList()
        {
            var AvarageSalary = Math.Round(EmployeesList.Select(x => x.Salary).Average(), 0);
            int EmployeesCount = EmployeesList.Count();
                Console.WriteLine("Работников: {0}, Средняя зарплата: {1} руб.", EmployeesCount, AvarageSalary);

            var ImprovedEmployee = from i in EmployeesList where i.Rating == 10 select i;
            foreach (Person i in ImprovedEmployee)
                Console.WriteLine("Лучший работник: {0} {1} {2}, {3}", i.SecondName, i.FirstName, i.MiddleName, i.Position);
        }
    }
}
