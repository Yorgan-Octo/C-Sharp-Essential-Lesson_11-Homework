using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList arrayList = new ArrayList();

            arrayList.Add(new LinkClass("className 1"));
            arrayList.Add(new LinkClass("className 2"));

            arrayList.Add(12);
            arrayList.Add(20);

            arrayList.Add(new LinkStruct("structName 1"));
            arrayList.Add(new LinkStruct("structName 2"));

            arrayList.Add("Hello");
            arrayList.Add("World");

            for (int i = 0; i < arrayList.Count; i++)
            {

                //ArrayList дозволяє зберігати різні типи даних,
                //і тому необхідно здійснити приведення типів при отриманні елементів з колекції.
                //інакше я не зможу звертатися до функцій або полів класу або структури

                if (arrayList[i] is LinkClass)
                {
                    LinkClass temp = (LinkClass)arrayList[i];
                    Console.WriteLine(temp.ClassName);
                }
                else if (arrayList[i] is LinkStruct)
                {
                    LinkStruct temp = (LinkStruct)arrayList[i];
                    Console.WriteLine(temp.StructName);
                }
                else
                {

                    Console.WriteLine(arrayList[i]);
                }
            }
            //Якщо не правильно виконати приведення типів при отриманні
            //елементів з колекції,  виникатють помилки.

            //використовує додаткову пам'ять для зберігання інформації про типи,
            //що може призвести до великої витрати пам'яті, особливо при великих колекціях да і код буде більше іза постінйх перевірок.


            Console.ReadKey();
        }
    }

    public class LinkClass
    {
        public string ClassName;

        public LinkClass(string className)
        {
            ClassName = className;
        }
    }

    public struct LinkStruct
    {
        public string StructName;

        public LinkStruct(string structName)
        {
            StructName = structName;
        }
    }

}
