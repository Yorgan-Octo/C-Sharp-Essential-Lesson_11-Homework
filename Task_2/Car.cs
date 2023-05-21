using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{

    public abstract class Transport
    {
        protected string _typeTransport;

        public string Model { get; set; }
        public int ReleaseYear { get; set; }


        public Transport()
        {

        }

        public Transport(string model, int releaseYear)
        {
            Model = model;
            ReleaseYear = releaseYear;
        }

        public abstract void ShowBasInfo();
    }


    public class Car : Transport
    {
        public Car()
        {

        }
        public Car(string model, int releaseYear) : base(model, releaseYear)
        {
            _typeTransport = "Легковой Автомобыль";
        }

        public override void ShowBasInfo()
        {
            Console.WriteLine($"{_typeTransport} {Model} {ReleaseYear}");
        }

    }

    public class SportsCar : Transport
    {
        public SportsCar()
        {

        }
        public SportsCar(string model, int releaseYear) : base(model, releaseYear)
        {
            _typeTransport = "Спортивний Автомобыль";
        }

        public override void ShowBasInfo()
        {
            Console.WriteLine($"{_typeTransport} {Model} {ReleaseYear}");
        }

    }
}
