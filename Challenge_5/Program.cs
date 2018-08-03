using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Customer First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Customer Last Name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter Type Of Customer:");
            string typeOf = Console.ReadLine();

            Customer customer = new Customer(firstName, lastName, typeOf);
            Console.WriteLine(customer);

            foreach (string customerType in Customer)
            {
                if (customerType == "Potential")
                    Console.WriteLine("Come Join Us For GREAT Rates On Jet Ski Insurance!");
                else if (customerType == "Current")
                    Console.WriteLine("Thank You For Being A Customer, Have A Coupon For One Free Starbucks Coffee!");
                else if  (customerType == "Past")
                    Console.WriteLine("Baby Come Back, You Can Get $5 Off Your Last Rate!");
            }








        }
    }
}
