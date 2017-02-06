using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
   public class CustomList<T> : IEnumerable
    {

    public T[] myArray = new T[3];
        public int Count = 0;
        public string Enumerator;

        public  class Customlist<Z,X>
        {


            
        }
        public void Add(T result)
        {

            T[] tempArray = new T[myArray.Length + 5];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = tempArray[i];
            }
            Count++;               
            myArray = tempArray;
        }

        public void Remove(T value)
        {


            T[] tempArray = new T[myArray.Length];
            for (int i = 0; i > myArray.Length; i++)
            {
                if (value.Equals(myArray[i]))
                {
                    myArray[i] = tempArray[i];
                }
                tempArray[i] = myArray[i];
            }
            
            
            Count--;




        }

        public void MinusOverload()
        {
            
        }




        public void PlusOverload()
        {

        }



        public void Zip()
        {

        }





        public void OverloadString()
        {

        }







        
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return myArray[i];

            }
        }
    }
}
