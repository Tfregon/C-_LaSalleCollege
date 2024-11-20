using Project_Final_Mood_Fodd_Tracker.Classes;
using System.Collections;
using System.Data;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
/*
Student: Thomas Edson Fregoneze         number: 2332294
 
Class OOP

Notes: Miss my program looks simple and I believe it is, but I had done several times the sugestion
function to works fine with the dinamic informations, I am happy with the result and for sure I could 
really understand what I saw in class, Thank you for yours explanation.
 */
namespace Project_Final_Mood_Fodd_Tracker
{
    public partial class Form1 : Form
    {
        //Variables Global Scope=====================================================
        #region
        public MealManager mealManager = new MealManager(); // dictionary
        public FoodManager foodManager = new FoodManager(); // list

        int idFood = 1;
        int idMeal = 1;

        string name = Start.userName;

        string preference;
        bool allergyGluten;
        bool allergyLactose;
        bool allergySeaFood;
        #endregion
        //===========================================================================
        public Form1()
        {
            InitializeComponent();
            textBoxRegisterFoodId.Text = idFood.ToString();
            textBoxFoodIdRegisMeal.Text = idMeal.ToString();

            labelNameUser.Text = "Please " + name + "\n do not Forget to chose the allergy option!";
            labelHowIsYourMoodNow.Text = name + "\nWhich is your mood right now?";
        }
        //Buttons Add and Del for Food and Meal=======================================
        #region
        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            Food food = new Food();
            food.FoodId = idFood;
            food.FoodName = textBoxRegisterFoodName.Text;
            food.FoodCategory = checkedListBoxCategory.Text;
            food.FoodType = checkedListBoxAlertAboutAllergy.Text;

            foodManager.addFood(food);

            idFood += 1;

            loadDataFoodInMeal();
            clearTextFood();
        }
        private void buttonDelFood_Click(object sender, EventArgs e)
        {
            int idSelected = Convert.ToInt32(textBoxRegisterFoodId.Text);
            foreach (Food food in foodManager.FoodList)
            {
                if (food.FoodId == idSelected)
                {
                    foodManager.FoodList.Remove(food);
                    break;
                }
            }

            if (idMeal == 1)
            {
                idMeal = 1;
            }
            if (idMeal > 1)
            {
                idMeal = --idMeal;
            }

            loadDataFoodInMeal();
            clearTextMeal();
        }

        private void buttonAddMeal_Click(object sender, EventArgs e)
        {
            Meal meal = new Meal();
            meal.MealId = idMeal;
            foreach (Food food in foodManager.FoodList)
            {
                if (food.FoodName == checkedListBoxFoodNameOption.Text)
                {
                    meal.MealNameObj = food;
                }
            }
            meal.Period = checkedListBoxPeriod.Text;
            meal.PreScore = Convert.ToInt32(checkedListBoxPreMeal.Text);
            meal.PosScore = Convert.ToInt32(checkedListBoxPosMeal.Text);

            //FoodManager mealList = new FoodManager();

            mealManager.Meals.Add(meal);
            mealManager.addMeal(idMeal, mealManager.Meals);

            idMeal += 1;
            UncheckAllItems(checkedListBoxFoodNameOption);
            clearTextMeal();
        }
        private void buttonDelMeal_Click(object sender, EventArgs e)
        {
            int idSelectedMeal = Convert.ToInt32(textBoxFoodIdRegisMeal.Text);

            mealManager.removeMeal(idSelectedMeal);
            if (idMeal == 1)
            {
                idMeal = 1;
            }
            if (idMeal > 1)
            {
                idMeal = --idMeal;
            }
            UncheckAllItems(checkedListBoxFoodNameOption);
            loadDataFoodInMeal();
            clearTextMeal();

            textBoxFoodIdRegisMeal.Text = Convert.ToString(idMeal);
        }
        #endregion
        //Functions===================================================================

        //Functions to handler as load/ clear/ radiobtn/ exit=========================
        #region
        private void loadDataFoodInMeal() //atualiza e carrega as novas comidas disponiveis em meal
        {
            checkedListBoxFoodNameOption.Items.Clear();
            foreach (Food food in foodManager.FoodList)
            {
                checkedListBoxFoodNameOption.Items.Add(food.FoodName);
            }
        }

        private void clearTextFood()
        {
            textBoxRegisterFoodName.Clear();
            UncheckAllItems(checkedListBoxAlertAboutAllergy);
            UncheckAllItems(checkedListBoxCategory);

            checkedListBoxAlertAboutAllergy.ClearSelected();
            checkedListBoxCategory.ClearSelected();

            textBoxRegisterFoodId.Text = idFood.ToString();
        }

        private void clearTextMeal()
        {
            UncheckAllItems(checkedListBoxPeriod);
            UncheckAllItems(checkedListBoxPortionSize);
            UncheckAllItems(checkedListBoxPreMeal);
            UncheckAllItems(checkedListBoxPosMeal);

            checkedListBoxFoodNameOption.ClearSelected();
            checkedListBoxPeriod.ClearSelected();
            checkedListBoxPortionSize.ClearSelected();
            checkedListBoxPreMeal.ClearSelected();
            checkedListBoxPosMeal.ClearSelected();

            textBoxFoodIdRegisMeal.Text = idMeal.ToString();
        }

        private void UncheckAllItems(CheckedListBox checkedListBox)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, false);
            }
        }

        private int chooseRange(Meal meal)
        {
            int result;

            if (meal.PreScore < meal.PosScore)
            {
                result = meal.PosScore - meal.PreScore;
                if (result > 5)
                {
                    return result = 3;
                }
                else if (result < 5)
                {
                    return result = 2;
                }
            }
            return result = 1;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonResetRadioButtons_Click(object sender, EventArgs e)
        {
            preference = "";

            radioButtonPast.Enabled = true;
            radioButtonVeg.Enabled = true;
            radioButtonMeat.Enabled = true;
            radioButtonSeaF.Enabled = true;
            radioButtonFruits.Enabled = true;
        }



        #endregion
        //============================================================================

        //Radio Buttons===============================================================
        #region
        private void radioButtonPast_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPast.Checked)
            {
                preference = "Pasta";

                radioButtonVeg.Enabled = false;
                radioButtonMeat.Enabled = false;
                radioButtonSeaF.Enabled = false;
                radioButtonFruits.Enabled = false;
            }
        }

        private void radioButtonFruits_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFruits.Checked)
            {
                preference = "Fruit";

                radioButtonVeg.Enabled = false;
                radioButtonMeat.Enabled = false;
                radioButtonSeaF.Enabled = false;
                radioButtonPast.Enabled = false;
            }
        }

        private void radioButtonVeg_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVeg.Checked)
            {
                preference = "Vegetable";

                radioButtonFruits.Enabled = false;
                radioButtonMeat.Enabled = false;
                radioButtonSeaF.Enabled = false;
                radioButtonPast.Enabled = false;
            }
        }

        private void radioButtonSeaF_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSeaF.Checked)
            {
                preference = "Sea Food";

                radioButtonVeg.Enabled = false;
                radioButtonMeat.Enabled = false;
                radioButtonFruits.Enabled = false;
                radioButtonPast.Enabled = false;
            }
        }

        private void radioButtonMeat_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMeat.Checked)
            {
                preference = "Meat";

                radioButtonVeg.Enabled = false;
                radioButtonFruits.Enabled = false;
                radioButtonSeaF.Enabled = false;
                radioButtonPast.Enabled = false;
            }
        }
        #endregion
        //preferences=================================================================

        //Buttons Allergy=============================================================
        #region
        private void checkBoxGluten_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGluten.Checked)
            {
                allergyGluten = true;
            }
            else if (!checkBoxGluten.Checked)
            {
                allergyGluten = false;
            }
        }

        private void checkBoxLactose_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLactose.Checked)
            {
                allergyLactose = true;
            }
            else if (!checkBoxLactose.Checked)
            {
                allergyLactose = false;
            }
        }

        private void checkBoxSeaFood_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSeaFood.Checked)
            {
                allergySeaFood = true;
            }
            else if (!checkBoxSeaFood.Checked)
            {
                allergySeaFood = false;
            }
        }
        #endregion
        //Allergy=====================================================================

        //Sugestion===================================================================
        #region
        private void buttonShowSugestion_Click(object sender, EventArgs e)
        {
            SugestionTab.SelectedIndex = 1;

            string mood = checkedListBoxMoodForSugestion.Text;

            DataTable dt = new DataTable();
            dt.Columns.Add("Food");
            dt.Columns.Add("Size");

            foreach (Meal meal in mealManager.Meals)
            {
                switch (mood)
                {
                    case "Sad":
                    case "SoSo":
                        if (chooseRange(meal) == 3) // Somente notas altas para melhorar o humor
                        {
                            if ((allergyGluten == true && meal.MealNameObj.FoodType != "Gluten") ||
                                (allergyLactose == true && meal.MealNameObj.FoodType != "Lactose") ||
                                (allergySeaFood == true && meal.MealNameObj.FoodType != "Sea Food") ||
                                (allergyGluten == false && allergyLactose == false && allergySeaFood == false))
                            {
                                if (meal.MealNameObj.FoodCategory == preference || string.IsNullOrEmpty(preference))
                                {
                                    dt.Rows.Add(meal.MealNameObj.FoodName, "Medium");
                                }
                            }
                        }
                        break;
                    case "Happy":
                        if (chooseRange(meal) == 2 || chooseRange(meal) == 1)
                        {
                            if ((allergyGluten == true && meal.MealNameObj.FoodType != "Gluten") ||
                                (allergyLactose == true && meal.MealNameObj.FoodType != "Lactose") ||
                                (allergySeaFood == true && meal.MealNameObj.FoodType != "Sea Food") ||
                                (allergyGluten == false && allergyLactose == false && allergySeaFood == false))
                            {
                                if (meal.MealNameObj.FoodCategory == preference || string.IsNullOrEmpty(preference))
                                {
                                    dt.Rows.Add(meal.MealNameObj.FoodName, "Medium");
                                }
                            }
                        }
                        break;
                }
                dataGridViewSugestionList.DataSource = dt;
            }
        }
        #endregion
        //============================================================================

        //FeedBack and Exit App=======================================================
        #region
        private void buttonExitSugestion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxFB1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxFB1.Checked) 
            {
                checkBoxFB2.Enabled = false;
                checkBoxFB3.Enabled = false;
                checkBoxFB4.Enabled = false;
                checkBoxFB5.Enabled = false;
                MessageBox.Show("Looks Like you did not enjoy the application! Sorry about that!"); 
            }
        }

        private void checkBoxFB2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFB2.Checked)
            {
                checkBoxFB1.Enabled = false;
                checkBoxFB3.Enabled = false;
                checkBoxFB4.Enabled = false;
                checkBoxFB5.Enabled = false;
                MessageBox.Show("Looks Like you did not enjoy the application! Sorry about that!");
            }
        }

        private void checkBoxFB3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFB3.Checked)
            {
                checkBoxFB2.Enabled = false;
                checkBoxFB1.Enabled = false;
                checkBoxFB4.Enabled = false;
                checkBoxFB5.Enabled = false;
                MessageBox.Show("We hope see you soon on application!");
            }
        }

        private void checkBoxFB4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFB4.Checked)
            {
                checkBoxFB2.Enabled = false;
                checkBoxFB3.Enabled = false;
                checkBoxFB1.Enabled = false;
                checkBoxFB5.Enabled = false;
                MessageBox.Show("Looks Like you enjoyed the application!");
            }
        }

        private void checkBoxFB5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFB5.Checked)
            {
                checkBoxFB2.Enabled = false;
                checkBoxFB3.Enabled = false;
                checkBoxFB4.Enabled = false;
                checkBoxFB1.Enabled = false;
                MessageBox.Show("Thank you very much "+ name+"!");
            }
        }
    }
    #endregion
        //============================================================================
}