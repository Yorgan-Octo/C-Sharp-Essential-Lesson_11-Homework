using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class MyDictionary<T, R>
    {
        private T[] keyDictionary;
        private R[] valuesDictionary;

        public int Count { get { return keyDictionary.Length; } }

        public MyDictionary()
        {
            this.keyDictionary = new T[0];
            this.valuesDictionary = new R[0];
        }

        public R this[T key]
        {
            get
            {

                for (int i = 0; i < keyDictionary.Length; i++)
                {
                    if (keyDictionary[i].Equals(key))
                    {
                        return valuesDictionary[i];
                    }
                }

                throw new ArgumentException("Такого ключа в словнику немае");
            }
        }
        public R this[int index]
        {
            get
            {
                return valuesDictionary[index];
            }
        }

        public void Add(T key, R values)
        {
            if (!ContainsKey(key))
                Array.Resize(ref keyDictionary, keyDictionary.Length + 1);
            else
                throw new ArgumentException("Такой ключ уже существует");


            Array.Resize(ref valuesDictionary, valuesDictionary.Length + 1);

            keyDictionary[keyDictionary.Length - 1] = key;
            valuesDictionary[valuesDictionary.Length - 1] = values;
        }

        public bool ContainsKey(T key)
        {
            foreach (var item in keyDictionary)
            {
                if (item.Equals(key))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
