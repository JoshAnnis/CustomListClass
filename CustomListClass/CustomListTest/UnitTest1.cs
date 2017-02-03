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
            list.Add(2);
            
            //Assert
            Assert.AreEqual(list.count, result);
         }


        [TestMethod]
        public void RemoveformArray()
        {
            CustomList<int> list = new CustomList<int>() {4,3} ;
            int result = 1;

            list.Remove(1);

            Assert.AreEqual(list.count,result);
            

        }
        

    }
}
