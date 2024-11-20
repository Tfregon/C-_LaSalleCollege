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
 
    public partial class Form2 : Form
    {
        public static Patient patientForm2 = new Patient();
        public Form2()
        {
            InitializeComponent();
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            patientForm2.ExamDate = Convert.ToDateTime(dateTimePickerSchedule.Text);
         
            patientForm2.DoctorName = checkedListBoxDoctor.Text;
            patientForm2.NurseName = checkedListBoxNurse.Text;
            if (checkBoxBlood.Checked == true)
            {
                patientForm2.ExamName = "Blood";
            }
            else if(checkBoxCheckUp.Checked == true) 
            {
                 patientForm2.ExamName = "Check-Up";
            }
            else if (checkBoxXray.Checked == true) 
            {
                patientForm2.ExamName = "X-Ray";
            }

            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxBlood_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBlood.Checked == true) 
            {
                checkBoxCheckUp.Enabled = false;
                checkBoxXray.Enabled = false;
            }
        }

        private void checkBoxXray_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxXray.Checked) 
            {
                checkBoxCheckUp.Enabled= false;
                checkBoxBlood.Enabled= false;
            }
        }

        private void checkBoxCheckUp_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxCheckUp.Checked)
            {
                checkBoxBlood.Enabled = false;
                checkBoxXray.Enabled= false;
            }
        }
    }
}
