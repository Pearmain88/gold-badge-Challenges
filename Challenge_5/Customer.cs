using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    class Customer
    {
        public List<Customer> _customer = new List<Customer>();

        public Customer(string firstName, string lastName, string typeOf)
        {
            FirstName = firstName;
            LastName = lastName;
            TypeOf = typeOf;             
        }

        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("You need to enter your first name");

                _firstName = value;
            }
        }

        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("You need to enter your last name");

                _lastName = value;
            }
        }

        private string _typeOf;
        public string TypeOf
        {
            get => _typeOf;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Customer Types: Potential, Current, Past");

                _typeOf = value;
            }
        }
        public void AddCustomerToList(Customer addCustomer)
        {
            _customer.Add(addCustomer);
        }


    







    }
}
