using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final_Mood_Fodd_Tracker.Classes
{
    public class Food
    {
        private int foodId;
        private string foodName;
        private string foodType;//allergy
        private string foodCategory;

        public Food() { }
        public Food(int foodId, string foodName, string foodType, string foodCategory)
        {
            this.foodId = foodId;
            this.foodName = foodName;
            this.foodType = foodType;
            this.foodCategory = foodCategory;
        }

        public int FoodId { get => foodId; set => foodId = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public string FoodType { get => foodType; set => foodType = value; }
        public string FoodCategory { get => foodCategory; set => foodCategory = value; }
    }
}
