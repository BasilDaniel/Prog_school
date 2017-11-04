using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args) 
        {
            NumbersList Numbers = new NumbersList(); //First task
            Numbers.GetSumOfEvenNumbers();

            Employee Employees = new Employee(); //Second task
            Employees.AddNewEmployeeToList("Лозанов", "Валерий", "Арсениевич", 42, "Сварщик", 22000, 1);
            Employees.AddNewEmployeeToList("Гречко", "Бронислав", "Ульянович", 40, "Такелажник", 22000, 2);
            Employees.AddNewEmployeeToList("Шаломенцев", "Василий", "Святославович", 38, "Грузчик", 20000, 3);
            Employees.AddNewEmployeeToList("Вавилов", "Руслан", "Пахомович", 25, "Слесарь", 22000, 4);
            Employees.AddNewEmployeeToList("Якунов", "Федор", "Куприянович", 30, "Электромонтер", 24000, 5);
            Employees.AddNewEmployeeToList("Державин", "Осип", "Владимирович", 35, "Электромеханик", 25000, 6);
            Employees.AddNewEmployeeToList("Шеховцов", "Данил", "Ефремович", 33, "Монтер", 22000, 7);
            Employees.AddNewEmployeeToList("Кочнев", "Серафим", "Иннокентиевич", 39, "Диагност", 24000, 8);
            Employees.AddNewEmployeeToList("Хорьков", "Прокл", "Елисеевич", 37, "Начальник отдела", 29000, 9);
            Employees.AddNewEmployeeToList("Козарь", "Юрий", "Ермолаевич", 36, "Заведующий складом", 22000, 10);
            Employees.AddNewEmployeeToList("Моренов", "Вадим", "Игоревич", 32, "Водитель", 20000, 4);
            Employees.AddNewEmployeeToList("Кузинов", "Платон", "Севастьянович", 31, "Наладчик", 24000, 5);
            Employees.AddNewEmployeeToList("Табернакулов", "Варфоломей", "Михаилович", 26, "Мастер по укладке труб", 22000, 6);
            Employees.AddNewEmployeeToList("Просвирякова", "Эвелина", "Кондратиевич", 25, "Экономист", 22000, 7);
            Employees.AddNewEmployeeToList("Камалова", "Алла", "Марковна", 27, "Бухгалтер", 25000, 1);
            Employees.AddNewEmployeeToList("Родзянко", "Рада", "Серафимовна", 29, "Юрист", 25000, 2);
            Employees.AddNewEmployeeToList("Толстокожева", "Кира", "Эммануиловна", 31, "Машинистка", 17000, 3);
            Employees.AddNewEmployeeToList("Капшукова", "Наталия", "Сидоровна", 33, "Секретарь", 20000, 4);
            Employees.AddNewEmployeeToList("Вергунова", "Лилия", "Вадимовна", 35, "Заведующий складом", 24000, 5);
            Employees.AddNewEmployeeToList("Гоминова", "Каролина", "Станиславовна", 37, "Кладовщик", 22000, 6);
            Employees.AddNewEmployeeToList("Шипулина", "Виктория", "Гавриловна", 39, "Уборщица", 15000, 7);
            Employees.AddNewEmployeeToList("Экспериментова", "Бронислава", "Вацлавовна", 40, "Вахтер", 15000, 8);
            Employees.AddNewEmployeeToList("Полынова", "Кристина", "Петровна", 41, "Инженер по охране труда", 22000, 9);
            Employees.AddNewEmployeeToList("Кооскора", "Агния", "Потаповна", 42, "Инженер по обучению", 22000, 7);
            Employees.AddNewEmployeeToList("Адоратская", "Валентина", "Мироновна", 24, "Сметчица", 23000, 5);
            Employees.AddNewEmployeeToList("Ковпака", "Ольга", "Самуиловна", 23, "Специалист по закупкам", 23000, 6);
            Employees.AddNewEmployeeToList("Капитонова", "Анастасия", "Руслановна", 22, "Инженер по качеству", 23000, 8);
            Employees.AddNewEmployeeToList("Евстигнеева", "Кристина", "Теодоровна", 48, "Директор", 40000, 9);

            Employees.ConsoleEmployeesList();

            Console.ReadKey();
        }
    }
}
