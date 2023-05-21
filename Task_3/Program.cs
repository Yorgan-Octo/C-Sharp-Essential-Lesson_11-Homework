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

            myDictionary.Add("A1", 111);
            myDictionary.Add("A2", 222);
            myDictionary.Add("A3", 333);

            //myDictionary.Add("A1", 34555); //видасть ошибку так як такой клбюч уже существует!

            //звертання по ключу
            if (myDictionary.ContainsKey("A1"))
            {
                Console.WriteLine(myDictionary["A1"]);
            }

            if (myDictionary.ContainsKey("A67"))
            {
                Console.WriteLine(myDictionary["A1"]);
            }

            //Console.WriteLine(myDictionary["Ф34"]); //видасть ошибку так як такого ключа немае!


            //звертання во індексу
            Console.WriteLine(new String('-', 50));

            for (int i = 0; i < myDictionary.Count; i++)
            {
                Console.WriteLine(myDictionary[i]);
            }

            Console.ReadKey();
        }
    }
}
