using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class Menu_Repository
    {

        private List<Menu> _menu = new List<Menu>();

        public void AddItemToMenu(Menu meal)
        {
            _menu.Add(meal);
        }

        public List<Menu> GetMenu()
        {
            return _menu;
        }

        public void RemoveMenuItem(Menu goAway)
        {
            _menu.Remove(goAway);
        }

        public Menu FindFoodByName(string name)
        {
            var foodLookup = new Menu();
            foreach (var menuItem in _menu)
            {
                if (name == menuItem.MealName)
                {
                    foodLookup = menuItem;
                    break;
                }
            }
            return foodLookup;
        }

        
        






    }
}
