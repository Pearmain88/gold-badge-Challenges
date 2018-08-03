using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class OutingUI
    {
        private OutingRepo _outingRepo = new OutingRepo();

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
                        PrintAllNames();
                        break;
                    case 2:
                        PrintAllNamesWithDetail();
                        break;
                    case 3:
                        while (true)
                        {
                            Console.WriteLine("What type of outing is this");
                            string type = Console.ReadLine();

                            Console.WriteLine("How many people attended?");
                            int attended = int.Parse(Console.ReadLine());

                            Console.WriteLine("Date of outing (YYYY, MM, DD)");
                            string iDateOfOuting = Console.ReadLine();
                            DateTime date = Convert.ToDateTime(iDateOfOuting);

                            Console.WriteLine("What is the cost per person?");
                            decimal costPer = decimal.Parse(Console.ReadLine());

                            Outing newOuting = new Outing(type, attended, date, costPer);
                            _outingRepo.AddToList(newOuting);

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
                        TotalAllOutings();
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
                "1. Show all Outings. \n" +
                "2. Show all outings with detail. \n" +
                "3. Add new outing to list. \n" +
                "4. Total cost for all Outings this year. \n" +
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
            Outing bowl = new Outing("bowling", 12, new DateTime(2015, 12, 24), 25.45m);
            Outing water = new Outing("splash park", 22, new DateTime(2015, 07, 04), 57.22m);
            Outing golfing = new Outing("puttputt", 5, new DateTime(2015, 08, 15), 12.50m);
            Outing concert = new Outing("the beach boys", 27, new DateTime(2015, 05, 27), 35.25m);

            _outingRepo.AddToList(bowl);
            _outingRepo.AddToList(water);
            _outingRepo.AddToList(golfing);
            _outingRepo.AddToList(concert);
        }

        private void PrintAllNames()
        {
            Console.Clear();
            var outings = _outingRepo.GetList();
            foreach (Outing item in outings)
            {
                Console.WriteLine(item.EventType);
            }
        }
        private void TotalAllOutings()
        {
            var totalOutings = _outingRepo.GetList();
            decimal costTotal = 0;
            foreach (var eachOuting in totalOutings)
            {
                costTotal += eachOuting.TotalCost;
                Console.WriteLine(costTotal);
            }
        }
        
        private void PrintAllNamesWithDetail()
        {
            Console.Clear();
            var details = _outingRepo.GetList();
            foreach (var item in details)
            {
                Console.WriteLine($"Type of Event: {item.EventType} \n" +
                    $"Number Attended: {item.Attended} \n" +
                    $"Date of Event: {item.DateOfEvent} \n" +
                    $"Cost Per Person: {item.CostPerPerson} \n");
            }
        }

    }
}
