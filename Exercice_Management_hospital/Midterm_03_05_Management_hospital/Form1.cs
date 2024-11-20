using Midterm_03_05_Management_hospital.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_03_05_Management_hospital
{

    public partial class Form1 : Form
    {
        public static Patient patient = new Patient();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            
            patient.GivenName = textBoxFirstName.Text;
            patient.FamilyName = textBoxlastName.Text;

            patient.GenderPerson = new Gender();

            patient.GenderPerson.GenderType = Convert.ToString(checkedListBox1.Text);
            patient.Phone = textBoxPhone.Text;

            patient.Adress = new Adress();

            patient.Adress.CodalPost = textBoxPostalCode.Text;
            patient.Adress.Unit1 = Convert.ToInt16(textBoxUnit.Text);
            patient.Adress.City = textBoxCity.Text;
            patient.Id = textBoxID.Text;
            patient.BirthDate = Convert.ToDateTime(dateTimePickerBirthday.Text);

            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
