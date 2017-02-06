using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> test = new CustomList<int>() { 4, 3 };
            //foreach (string day in CustomListClass<T>)

            List<int> list1 = new List<int>() { 1, 2, 3 };
            List<int> list2 = new List<int>() { 4, 5, 6 };
        }
    }

}
