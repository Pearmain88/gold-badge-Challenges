using System;
using System.Collections.Generic;
using Challenge_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_2_Tests
{
    [TestClass]
    public class UnitTest1
    {
        ClaimsQueueRepo claimsRepo = new ClaimsQueueRepo();

        [TestMethod]
        public void ClaimsQueueRepo_GetQueue_ShouldReturnList()
        {
            //--Arrange
            Queue<Claims> getQueueTest = claimsRepo.GetQueue();
            //--Act
            int actual = getQueueTest.Count;
            int expected = 0;
            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void  ClaimsQueueRepo_RemoveItem_ShouldRemoveItem()
        {
            //--Arrange
            Claims one = new Claims();
            claimsRepo.ViewItemsInQueue(one);
            Claims two = new Claims();
            claimsRepo.ViewItemsInQueue(two);
            claimsRepo.RemoveItemFromQueue();
            Queue<Claims> removeItemTest = claimsRepo.GetQueue();
            //--Act
            int actual = removeItemTest.Count;
            int expected = 1;
            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ClaimsQueueRepo_PrintList_ShouldReturnList()
        {
            //--Arrange
            Claims one = new Claims();
            claimsRepo.ViewItemsInQueue(one);
            Claims two = new Claims();
            claimsRepo.ViewItemsInQueue(two);
            Queue<Claims> printListTest = claimsRepo.GetQueue();
            //--Act
            int actual = printListTest.Count;
            int expected = 2;
            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
