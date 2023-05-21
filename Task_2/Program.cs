using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Transport> transport = new CarCollection<Transport>();
            CarCollection<Car> cars = new CarCollection<Car>();
            CarCollection<SportsCar> sportsCars = new CarCollection<SportsCar>();


            cars.Add(new Car("Lada 565", 1290));
            cars.Add(new Car("Lada 121", 1590));
            cars.Add(new Car("Lada 234", 1990));
            cars.Add(new Car("Lada 543", 1998));

            sportsCars.Add(new SportsCar("Lamborg 565", 1290));
            sportsCars.Add(new SportsCar("Lamborg 121", 1590));
            sportsCars.Add(new SportsCar("Lamborg 234", 1990));
            sportsCars.Add(new SportsCar("Lamborg 543", 1998));

            transport.Add(new SportsCar("Lamborg 565", 1290));
            transport.Add(new Car("Lada 565", 1290));
            transport.Add(new SportsCar("Lamborg 121", 1590));
            transport.Add(new Car("Lada 121", 1590));
            transport.Add(new SportsCar("Lamborg 543", 1998));

            cars[0].ShowBasInfo();
            sportsCars[0].ShowBasInfo();
            transport[0].ShowBasInfo();


            Console.WriteLine("---------------------");

            for (int i = 0; i < cars.Count; i++)
            {
                cars[i].ShowBasInfo();
            }

            Console.WriteLine("---------------------");

            for (int i = 0; i < sportsCars.Count; i++)
            {
                sportsCars[i].ShowBasInfo();
            }


            Console.WriteLine("---------------------");

            for (int i = 0; i < transport.Count; i++)
            {
                transport[i].ShowBasInfo();
            }


            Console.ReadKey();
        }
    }
}
