using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final_Mood_Fodd_Tracker.Classes
{
    public class FoodManager
    {
        private List<Food> foodList = new List<Food>();

        public FoodManager() { }

        public List<Food> FoodList { get => foodList; set => foodList = value; }

        public void addFood(Food food)
        { 
            foodList.Add(food);
        }

        public void removeFood(Food food) 
        {
            foodList.Remove(food);
        }
    }
}
