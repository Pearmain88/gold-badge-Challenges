using System;
using System.Collections.Generic;
using Challenge_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_1_Tests
{
    [TestClass]
    public class UnitTest1
    {
        Menu_Repository menuRepo = new Menu_Repository();
        [TestMethod]
        public void MenuRepository_AddToList_ShouldAddToList()
        {
            //--Arrange
            Menu menuItem = new Menu(6, "meatballs", "stuff", 5.00m, "things");
            menuRepo.AddItemToMenu(menuItem);
            List<Menu> menuListTest = menuRepo.GetMenu();
            //--Act
            int actual = menuListTest.Count;
            int expected = 1;
            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MenuRepostitory_GetMenu_ShouldGetMenu()
        {
            //--Arrange            
            List<Menu> getMenuTest = menuRepo.GetMenu();
            //--Act
            int actual = getMenuTest.Count;
            int expected = 0;
            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MenuRepository_RemoveItem_ShoudRemoveItem()
        {
            //--Arrange
            Menu foodOne = new Menu();
            menuRepo.AddItemToMenu(foodOne);
            Menu foodTwo = new Menu();
            menuRepo.AddItemToMenu(foodTwo);
            menuRepo.RemoveMenuItem(foodOne);
            List<Menu> removeItemTest = menuRepo.GetMenu();
            //--Act
            int actual = removeItemTest.Count;
            int expected = 1;
            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MenuRepository_FindFoodByName_ShouldReturnString()
        {
            //--Arrange
            List<Menu> findNameTest = menuRepo.GetMenu();
            Menu findName = new Menu(8, "Bratwurst", "Better than a hot dog", 4.99m, "Brat, bun, toppings");
            menuRepo.AddItemToMenu(findName);
            Menu foundIt = menuRepo.FindFoodByName("Bratwurst");
            //--Act
            string actual = foundIt.MealName;
            string expected = "Bratwurst";
            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
