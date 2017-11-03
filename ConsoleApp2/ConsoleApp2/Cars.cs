using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Cars
    {
        private string _brand;
        private string _model;
        private string _formFactor;
        private int _wheels;
        private int _doors;

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public string FormFactor
        {
            get { return _formFactor; }
            set { _formFactor = value; }
        }
        public int Wheels
        {
            get { return _wheels; }
            set { _wheels = value; }
        }
        public int Doors
        {
            get { return _doors; }
            set { _doors = value; }
        }

        public void GetYourCarGeneralInfo()
        {
            Console.WriteLine($"Brand - {Brand}");
            Console.WriteLine($"Model - {Model}");
            Console.WriteLine($"FormFactor - {FormFactor}");
            Console.WriteLine($"Wheels - {Wheels}");
            Console.WriteLine($"Doors - {Doors}");
        }
    }
}
