using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main()
        {

            MyArrayList myArrayList = new MyArrayList();

            myArrayList.Add(1);
            myArrayList.Add("Allo");
            myArrayList.Add(3);
            myArrayList.Add(4);
            myArrayList.Add("Hello");

            for (int i = 0; i < myArrayList.Count; i++)
            {
                Console.WriteLine(myArrayList[i]);
            }

            Console.WriteLine(new String('-',50));

            foreach (var item in myArrayList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
