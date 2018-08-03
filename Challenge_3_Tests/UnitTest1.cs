using System;
using System.Collections.Generic;
using Challenge_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_3_Tests
{
    [TestClass]
    public class UnitTest1
    {
        OutingRepo outingRepo = new OutingRepo();
        [TestMethod]
        public void OutingRepo_AddToList_ShouldAddToList()
        {
            //--Arrange
            Outing outingList = new Outing();
            outingRepo.AddToList(outingList);
            List<Outing> menuListTest = outingRepo.GetList();
            //--Act
            int actual = menuListTest.Count;
            int expected = 1;
            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OutingRepo_GetList_ShouldGetList()
        {
            //--Arrange            
            List<Outing> getListTest = outingRepo.GetList();
            //--Act
            int actual = getListTest.Count;
            int expected = 0;
            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
