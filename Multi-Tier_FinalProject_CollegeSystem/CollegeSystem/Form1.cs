using BLL;
using DAL;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeSystem
{
    public partial class Form1 : Form
    {
        internal static Form1 current;
        public Form1()
        {
            current = this;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new StudentsFormEdition();
            StudentsFormEdition.current.Visible = false;


            dataGridViewCollegeSystem.Visible = false;
            Text = "Students Programs and Courses";
            dataGridViewCollegeSystem.Dock = DockStyle.Fill;
        }

        private void studentsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dataGridViewCollegeSystem.Visible = true;

            dataGridViewCollegeSystem.ReadOnly = false;
            dataGridViewCollegeSystem.AllowUserToAddRows = true;
            dataGridViewCollegeSystem.AllowUserToDeleteRows = true;
            dataGridViewCollegeSystem.RowHeadersVisible = true;
            dataGridViewCollegeSystem.Dock = DockStyle.Fill;
            dataGridViewCollegeSystem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            bindingSourceStudents.DataSource = DAL.DataTables.GetDataSet().Tables["Students"];
            dataGridViewCollegeSystem.DataSource = bindingSourceStudents;
        }
        private void enrollmentsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dataGridViewCollegeSystem.Visible = true;

            dataGridViewCollegeSystem.ReadOnly = false;
            dataGridViewCollegeSystem.AllowUserToAddRows = true;
            dataGridViewCollegeSystem.AllowUserToDeleteRows = true;
            dataGridViewCollegeSystem.RowHeadersVisible = true;
            dataGridViewCollegeSystem.Dock = DockStyle.Fill;
            dataGridViewCollegeSystem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            bindingSourceEnrollments.DataSource = DAL.DataTables.GetDataSet().Tables["Enrollments"];
            dataGridViewCollegeSystem.DataSource = bindingSourceEnrollments;
        }

        private void coursesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dataGridViewCollegeSystem.Visible = true;

            dataGridViewCollegeSystem.ReadOnly = false;
            dataGridViewCollegeSystem.AllowUserToAddRows = true;
            dataGridViewCollegeSystem.AllowUserToDeleteRows = true;
            dataGridViewCollegeSystem.RowHeadersVisible = true;
            dataGridViewCollegeSystem.Dock = DockStyle.Fill;
            dataGridViewCollegeSystem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            bindingSourceCourses.DataSource = DAL.DataTables.GetDataSet().Tables["Courses"];
            dataGridViewCollegeSystem.DataSource = bindingSourceCourses;
        }

        private void programsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dataGridViewCollegeSystem.Visible = true;

            dataGridViewCollegeSystem.ReadOnly = false;
            dataGridViewCollegeSystem.AllowUserToAddRows = true;
            dataGridViewCollegeSystem.AllowUserToDeleteRows = true;
            dataGridViewCollegeSystem.RowHeadersVisible = true;
            dataGridViewCollegeSystem.Dock = DockStyle.Fill;
            dataGridViewCollegeSystem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            bindingSourcePrograms.DataSource = DAL.DataTables.GetDataSet().Tables["Programs"];
            dataGridViewCollegeSystem.DataSource = bindingSourcePrograms;
        }

        public void bindingSourceStudents_CurrentChanged(object sender, EventArgs e)
        {
            if (BLL.StudentsBLL.UpdateStudents() == -1)
            {
                bindingSourceStudents.ResetBindings(false);
            }
        }

        private void bindingSourceEnrollments_CurrentChanged(object sender, EventArgs e)
        {
            if (BLL.EnrollmentsBLL.UpdateEnrollments() == -1)
            {

                bindingSourceEnrollments.ResetBindings(false);
            }
        }

        private void bindingSourceCourses_CurrentChanged(object sender, EventArgs e)
        {
            if (BLL.CoursesBLL.UpdateCourses() == -1)
            {
                MessageBox.Show("Thats a mistake!");
                bindingSourceCourses.ResetBindings(false);
            }
        }

        private void bindingSourcePrograms_CurrentChanged(object sender, EventArgs e)
        {
            if (BLL.ProgramsBLL.UpdatePrograms() == -1)
            {
                bindingSourcePrograms.ResetBindings(false);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsFormEdition.current.Start(StudentsFormEdition.Modes.ADD, null);
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection c = dataGridViewCollegeSystem.SelectedRows;
            if (c.Count == 0)
            {
                MessageBox.Show("A line must be selected for update");
            }
            else if (c.Count > 1)
            {
                MessageBox.Show("Only one line must be selected for update");
            }
            else
            {
                if ("" + c[0].Cells["FinalGrade"].Value == "")
                {
                    StudentsFormEdition.current.Start(StudentsFormEdition.Modes.MODIFY, c);
                }
                else
                {
                    MessageBox.Show("For update this line, Grade value must be removed first.");
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection c = dataGridViewCollegeSystem.SelectedRows;
            if (c.Count == 0)
            {
                MessageBox.Show("At least one line must be selected for deletion");
            }
            else // (c.Count > 1)
            {
                List<string[]> lId = new List<string[]>();
                for (int i = 0; i < c.Count; i++)
                {
                    lId.Add(new string[] { "" + c[i].Cells["StId"].Value,
                                           "" + c[i].Cells["CId"].Value });
                }
                DAL.Enrollments.DeleteData(lId);
            }
        }

        private void gradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection c = dataGridViewCollegeSystem.SelectedRows;
            if (c.Count == 0)
            {
                MessageBox.Show("A line must be selected for evaluation update");
            }
            else if (c.Count > 1)
            {
                MessageBox.Show("Only one line must be selected for update");
            }
            else
            {
                StudentsFormEdition.current.Start(StudentsFormEdition.Modes.GRADE, c);
            }
        }

        internal static void BLLMessage(string s)
        {
            MessageBox.Show("Business Layer: " + s);
        }

        internal static void DALMessage(string s)
        {
            MessageBox.Show("Data Layer: " + s);
        }

        private void dataGridViewCollegeSystem_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("The course and Student cannot be duplicated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ThrowException = false; // Suprime a exceção padrão
            e.Cancel = true; // Cancela a operação que causou o erro
        }
    }
}

