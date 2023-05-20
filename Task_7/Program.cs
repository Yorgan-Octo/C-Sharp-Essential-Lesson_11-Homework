using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = MyClass.FacrotyMethod<Person>();

            Console.WriteLine(person.text);

            Console.ReadKey();

        }
    }
}
