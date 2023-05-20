using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    public class MyClass
    {
        //Якщо треба створити екземпляри типу за допомогою оператора new,то обмеження where T : new ().

        //Для заданого завдання, тип, що підставляється під T, повинен мати публічний конструктор
        //без параметрів, щоб фабричний метод міг створити новий екземпляр цього типу
        //за допомогою оператора new.

        public static T FacrotyMethod<T>() where T : new()
        {
            return new T();
        }

    }

    public class Person
    {
        public string text = "Створеный фабрычным методом";

    }
}
