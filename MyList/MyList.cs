using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    internal class MyList<T>
    {
        private T[] arr = new T[2];
        public T this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }
        public int Count { get; private set; } = 0;
        public void Add(T value)
        {
            if (Count < arr.Length)
            {
                arr[Count] = value;
                Count++;
            }
            else
            {
                ArrIncrease_x2();
                arr[Count] = value;
                Count++;
            }
        }
        public void Print()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        private void ArrIncrease_x2()
        {
            var newArray = new T[arr.Length * 2];
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[i];
            }
            arr = newArray;
        }
    }
}
