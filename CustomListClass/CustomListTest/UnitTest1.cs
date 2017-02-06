using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;
using System.Collections.Generic;
using System.Linq;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddtoArray()
        {
            //Arrange 
            CustomList<int> list = new CustomList<int>();
            int result = 1;
            //Act
            list.Add(2);

            //Assert
            Assert.AreEqual(list.Count, result);
        }


        [TestMethod]
        public void RemoveformArray()
        {
            CustomList<int> list = new CustomList<int>() { 4, 3 };
            int result = 1;

            list.Remove(1);

            Assert.AreEqual(list.Count, result);


        }
        [TestMethod]
        public void IiterableList()
        {
            CustomList<string> list = new CustomList<string>();
            string[] daysArray;
            daysArray = new string[] { "Sunday", "Monday", "Tuesday" };
            int expected = 3;
            int actual=0;

            foreach(string day in daysArray)
            {
                actual++; 
            }


            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void ListOverload()
        {
            CustomList<int> list = new CustomList<int>();
            List<int> final;
            List<int> list1 = new List<int>() { 1, 2, 3 };
            List<int> list2 = new List<int>() { 4, 5, 6 };
            final = list1 + list2;
            
        }


        [TestMethod]
        public void ListString()
        {

        }




    }
}
