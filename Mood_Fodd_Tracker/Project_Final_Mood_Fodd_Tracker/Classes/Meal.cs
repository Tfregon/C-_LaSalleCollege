using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final_Mood_Fodd_Tracker.Classes
{
    public class Meal
    {
        private int mealId;
        private string mealName; // not using
        Food mealNameObj;
        private string period;
        private string portionSize;
        private int preScore;
        private int posScore;
        public Meal() { }

        public Meal(int mealId, string mealName, string period, string portionSize, int preScore, int posScore)
        {
            this.mealId = mealId;
            this.mealName = mealName;
            this.period = period;
            this.portionSize = portionSize;
            this.preScore = preScore;
            this.posScore = posScore;
        }

        public Meal(int mealId, string mealName, Food mealNameObj, string period, string portionSize, int preScore, int posScore)
        {
            this.mealId = mealId;
            this.mealName = mealName;
            this.mealNameObj = mealNameObj;
            this.period = period;
            this.portionSize = portionSize;
            this.preScore = preScore;
            this.posScore = posScore;
        }

        public int MealId { get => mealId; set => mealId = value; }
        public string MealName { get => mealName; set => mealName = value; }//not using
        public string Period { get => period; set => period = value; }
        public string PortionSize { get => portionSize; set => portionSize = value; }
        public int PreScore { get => preScore; set => preScore = value; }
        public int PosScore { get => posScore; set => posScore = value; }
        public Food MealNameObj { get => mealNameObj; set => mealNameObj = value; }
    }
}
