using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final_Mood_Fodd_Tracker.Classes
{
    public class MealManager
    {
        private List<Meal> meals = new List<Meal>();

        private Dictionary<int,List<Meal>> mealFood = new Dictionary<int,List<Meal>>();
        public MealManager() { }

        public Dictionary<int, List<Meal>> MealFood { get => mealFood; set => mealFood = value; }
        public List<Meal> Meals { get => meals; set => meals = value; }

        public void addMealList(Meal meal)
        {
            meals.Add(meal);
        }
        public void removeMealList(Meal meal)
        {
            meals.Remove(meal);
        }
        public void addMeal(int  id, List<Meal> obj)
        { 
            mealFood.Add(id, obj); 
        }
        public void removeMeal(int id)
        {
            mealFood.Remove(id);
        }
    }
}
