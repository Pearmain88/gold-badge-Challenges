using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class ProgramUI
    {
        private ClaimsQueueRepo _claimsQueueRepo = new ClaimsQueueRepo();

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
                        ViewItemsInQueue();
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        while (true)
                        {
                            Console.WriteLine("What is the new Claim Number?");
                            int claimID = Int32.Parse(Console.ReadLine());

                            Console.WriteLine("What type of Claim?");
                            var type = Console.ReadLine();

                            Console.WriteLine("What is the description for the Claim?");
                            var description = Console.ReadLine();

                            Console.WriteLine("What is the Damage Cost of the Claim?");
                            decimal damages = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("What is the date of the Incident");
                            string iDateOfIncident = Console.ReadLine();
                            DateTime dateOfIncident = Convert.ToDateTime(iDateOfIncident);

                            Console.WriteLine("What is the date the Claim was made?");
                            string iDateOfClaim = Console.ReadLine();
                            DateTime dateOfClaim = Convert.ToDateTime(iDateOfClaim);

                            Claims claim = new Claims();
                            _claimsQueueRepo.ViewItemsInQueue(claim);

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
                "1. Show all Claims in the Queue. \n" +
                "2. Deal with next Claim in the Queue. \n" +
                "3. Add a new Claim to the Queue. \n" +
                "4. Exit."
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
            Claims Q1 = new Claims(45, "Car", "Fender Bender", 250.00m, new DateTime(05-10-2016), new DateTime(05-18-2016));
            Claims Q2 = new Claims(32, "House", "Domestic Dispute", 5000.00m, new DateTime(04-15-2016), new DateTime(05-18-2016));
            Claims Q3 = new Claims(68, "Theft", "Purse-Dog Taken", 600.00m, new DateTime(09-08-2016), new DateTime(09-09-2016));
            Claims Q4 = new Claims(122, "RV", "Camping Accident", 12542.97m, new DateTime(12-25-2016), new DateTime(01-15-2017));


            _claimsQueueRepo.ViewItemsInQueue(Q1);
            _claimsQueueRepo.ViewItemsInQueue(Q2);
            _claimsQueueRepo.ViewItemsInQueue(Q3);
            _claimsQueueRepo.ViewItemsInQueue(Q4);
        }
        private void ViewItemsInQueue()
        {
            Console.Clear();
            var details = _claimsQueueRepo.GetQueue();
            foreach (var item in details)
            {
                Console.WriteLine($"Claim ID Number: {item.ClaimID} \n" +
                    $"Description of Claim: {item.Description} \n" +
                    $"Claim Type: {item.TypeOfAccident} \n" +
                    $"Damage Cost: {item.AmountOfDamage} \n" +
                    $"Date of Incedent: {item.DateOfAccident} \n" +
                    $"Date of Claim: {item.ClaimDate} \n" +
                    $"Valid (True/False): {item.IsValidClaim} \n");
            }
        }





    }
}
