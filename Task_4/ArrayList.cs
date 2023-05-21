using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class MyArrayList : IEnumerable
    {

        private object[] listObject = new object[0];

        public int Count { get { return listObject.Length; } }

        public object this[int index]
        {
            get
            {
                if (index >= 0 && index < listObject.Length)
                {
                    return listObject[index];

                }

                throw new ArgumentException("Вихід за межі");
            }
        }

        public void Add(object obj)
        {
            Array.Resize(ref listObject, listObject.Length + 1);
            listObject[listObject.Length - 1] = obj;
        }

        public IEnumerator GetEnumerator()
        {
            return new MyArrayListEnumerator(this);
        }


        // Класс, реализующий IEnumerator
        private class MyArrayListEnumerator : IEnumerator
        {
            private MyArrayList collection;
            private int currentIndex;

            public MyArrayListEnumerator(MyArrayList collection)
            {
                this.collection = collection;
                currentIndex = -1;
            }

            public object Current => collection[currentIndex];

            public bool MoveNext()
            {
                currentIndex++;
                return currentIndex < collection.Count;
            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }

    }


}
