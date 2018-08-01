using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_6
{
    class ProgramUI
    {
        private Menu_Repository _menuRepo = new Menu_Repository();

        public void Run()
        {
            CreateSeedList();
            RunStartMenu();
        }
        private void RunStartMenu()
        {
            ShowStartMenu();
            bool continueToRunMenu = true;
            while (continueToRunMenu)
            {
                int choice = GetParseMenuChoice();
                switch (choice)
                {
                    case 1:
                        PrintAllFoodByName();
                        break;
                    case 2:
                        PrintAllFoodWithDetail();
                        break;
                    case 3:
                        while (true)
                        {
                            Console.WriteLine("What is the new meal number?");
                            int num = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("What is this meal called?");
                            var name = Console.ReadLine();
                            Console.WriteLine("What is the description?");
                            var desc = Console.ReadLine();
                            Console.WriteLine("What is the price?");
                            decimal pr = decimal.Parse(Console.ReadLine());
                            Console.WriteLine("Whats in it?");
                            string ingr = Console.ReadLine();

                            Menu userFood = new Menu(num, name, desc, pr, ingr);
                            _menuRepo.AddItemToMenu(userFood);

                            Console.WriteLine("Do you want to add something else? y/n");
                            string answer = Console.ReadLine();

                            if (answer == "y") { }
                            else if (answer == "n")
                            {
                                break;
                            }
                        }
                        break;
                    case 4:
                        while (true)
                        {
                            Console.WriteLine("Which item do you want to remove?");
                            string meal = Console.ReadLine();
                            var oldName = _menuRepo.FindFoodByName(meal);

                            Console.WriteLine("Do you want to delete this item?");
                            string theAnswer = Console.ReadLine();
                            if (theAnswer == "y")
                            {
                                _menuRepo.RemoveMenuItem(oldName);
                                break;
                            }
                            else if (theAnswer == "n")
                            {
                                break;
                            }

                        }
                        break;
                    case 5:
                        continueToRunMenu = false;
                        break;
                    default:
                        ShowStartMenu();
                        break;
                }
            }
        }
        private void ShowStartMenu()
        {
            Console.WriteLine("What would you like to do? \n" +
                "1. Show all food on the menu. \n" +
                "2. Show detail of food on menu. \n" +
                "3. Add new menu item. \n" +
                "4. Delete item from menu \n" +
                "5. Exit."
                );
        }

        private int GetParseMenuChoice()
        {
            Console.WriteLine("please make a selection:");
            string choiceAS = Console.ReadLine();
            int choice = Int32.Parse(choiceAS);
            return choice;
        }

        private void CreateSeedList()
        {
            Menu mealOne = new Menu(1, "Mac", "Everyones Favorite", 8.99m, "noodles, cheese, bacon");
            Menu mealTwo = new Menu(2, "Burger", "Its a Burger ", 9.99m, "Meat, bun, toppings");
            Menu mealThree = new Menu(3, "Cheeseburger", "Its a Burger but with Cheese", 10.99m, "Meat, cheese, bun, toppings");
            Menu mealFour = new Menu(4, "Salad", "Rabbit Food", 5.99m, "Lettuce and Such");
            Menu mealFive = new Menu(5, "UnSalad", "Its like Salad, but Better", 8.99m, "Lettuce, chicken, bacon, cheese, good stuff");


            _menuRepo.AddItemToMenu(mealOne);
            _menuRepo.AddItemToMenu(mealTwo);
            _menuRepo.AddItemToMenu(mealThree);
            _menuRepo.AddItemToMenu(mealFour);
            _menuRepo.AddItemToMenu(mealFive);
        }

        private void PrintAllFoodByName()
        {
            Console.Clear();
            var foods = _menuRepo.GetMenu();
            foreach (Menu item in foods)
            {
                Console.WriteLine(item.MealName);
            }
        }

        private void PrintAllFoodWithDetail()
        {
            Console.Clear();
            var details = _menuRepo.GetMenu();
            foreach (var item in details)
            {
                Console.WriteLine($"Meal Number: {item.MealNumber} \n" +
                    $"Meal Name: {item.MealName} \n" +
                    $"Description: {item.Description} \n" +
                    $"Ingredients: {item.Ingredients} \n" +
                    $"Price: {item.Price} \n");
            }
        }












    }
}
}
