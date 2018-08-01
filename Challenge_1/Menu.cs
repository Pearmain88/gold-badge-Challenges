using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{   //fields, constructors, properties
    public class Menu
    {

        //field
        //public List<Menu> _menu = new List<Menu>();
        public Menu()  { }
        //ctor
        public Menu(int num, string name, string desc, decimal pr, string ingr)
        {
            MealNumber = num;
            MealName = name;
            Description = desc;
            Ingredients = ingr;
            Price = pr;
        }
        //prop
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public decimal Price { get; set; }
    }
}
