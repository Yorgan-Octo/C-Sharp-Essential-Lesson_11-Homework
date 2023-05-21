using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class CarCollection<T> where T : Transport, new()
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

            set => parking[index] = value;
        }
        public void Add(string model, int releaseYear)
        {
            int newIndexLrngth = parking.Length + 1;

            Array.Resize(ref parking, newIndexLrngth);
            parking[newIndexLrngth - 1] = new T();

            parking[newIndexLrngth - 1].Model = model;
            parking[newIndexLrngth - 1].ReleaseYear = releaseYear;
        }
    }
}
