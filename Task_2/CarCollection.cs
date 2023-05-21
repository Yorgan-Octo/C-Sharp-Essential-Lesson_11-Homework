using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class CarCollection<T> where T : Transport
    {

        private T[] parking = new T[0];

        public int Count { get => parking.Length; }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count) 
                    throw new ArgumentException("За таким індексом нічого немае");

                return parking[index];
            }
        }
        public void Add(T item)
        {
            Array.Resize(ref parking, parking.Length + 1);
            parking[parking.Length - 1] = item;
        }
    }
}
