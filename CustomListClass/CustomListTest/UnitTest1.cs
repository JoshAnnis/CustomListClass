using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;
using System.Collections.Generic;

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
            list.Add(45);
            
            //Assert
            Assert.AreEqual(list.count, result);
         }


        [TestMethod]
        public void RemoveformArray()
        {
            CustomList<int> list = new CustomList<int>();
            int result = 0;
            list.Remove(0);
            Assert.AreEqual(list.myArray.Length, result);

        }



    }
}
