using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();

            Dictionary<string, int> map = new Dictionary<string, int>();

            map.Add("a", 2);
            map.Add("f", 3);

            myDictionary.Add("A1", 111);
            myDictionary.Add("A2", 222);
            myDictionary.Add("A3", 333);

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
