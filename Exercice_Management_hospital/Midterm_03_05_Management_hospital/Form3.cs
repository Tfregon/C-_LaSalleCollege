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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonShowInfo_Click(object sender, EventArgs e)
        {
            labelName.Text = Form1.patient.GivenName;
            labelNurse.Text = Form2.patientForm2.NurseName;
            labelDoctor.Text = Form2.patientForm2.DoctorName;
            labelTypeExam.Text = Form2.patientForm2.ExamName;
        }
    }
}
