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
            CarCollection<Car> cars = new CarCollection<Car>();
            CarCollection<SportsCar> sportsCars = new CarCollection<SportsCar>();


            cars.Add("Lada 565", 1290);
            cars.Add("Lada 121", 1590);
            cars.Add("Lada 234", 1990);
            cars.Add("Lada 543", 1998);

            sportsCars.Add("Lamborg 565", 1290);
            sportsCars.Add("Lamborg 121", 1590);
            sportsCars.Add("Lamborg 234", 1990);
            sportsCars.Add("Lamborg 543", 1998);

            cars[0].ShowBasInfo();
            sportsCars[0].ShowBasInfo();

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

            Console.ReadKey();
        }
    }
}
