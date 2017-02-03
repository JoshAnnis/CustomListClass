using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
   public class CustomList<T> : IEnumerable
    {

    public T[] myArray = new T[1];
        public int count = 0;
        

        public void Add(T result)
        {

            T[] tempArray = new T[myArray.Length + 5];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = tempArray[i];
            }
            count++;               
            myArray = tempArray;
        }

        public void Remove(int vaule)
        {

        }
    }
}
