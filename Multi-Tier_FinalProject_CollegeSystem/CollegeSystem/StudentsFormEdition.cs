using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CollegeSystem
{
    public partial class StudentsFormEdition : Form
    {
        internal enum Modes
        {
            ADD,
            MODIFY,
            DELETE,
            GRADE
        }

        internal static StudentsFormEdition current;

        private Modes mode = Modes.ADD;

        private string[] assignInitial;

        public StudentsFormEdition()
        {
            current = this;
            InitializeComponent();
        }

        internal void Start(Modes m, DataGridViewSelectedRowCollection c)
        {


            mode = m;
            Text = "" + mode;

            comboBoxStudentId.DisplayMember = "StId";
            comboBoxStudentId.ValueMember = "StId";
            comboBoxStudentId.DataSource = DAL.Students.GetStudents();
            comboBoxStudentId.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStudentId.SelectedIndex = 0; 

            comboBoxCourseId.DisplayMember = "CId";
            comboBoxCourseId.ValueMember = "CId";
            comboBoxCourseId.DataSource = DAL.Courses.GetCourses();
            comboBoxCourseId.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCourseId.SelectedIndex = 0;

            comboBoxProgramId.DisplayMember = "ProgId";
            comboBoxProgramId.ValueMember = "ProgId";
            comboBoxProgramId.DataSource = DAL.Programs.GetPrograms();
            comboBoxProgramId.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCourseId.SelectedIndex = 0;

            textBoxCourseName.ReadOnly = true;
            textBoxProgramName.ReadOnly = true;
            textBoxStudentName.ReadOnly = true;
            textBoxGrade.Enabled = false;

            if (((mode == Modes.MODIFY) || (mode == Modes.GRADE)) && (c != null))
            {
                DataRow[] selectedStudentRows = DAL.Students.GetStudents().Select($"StId = '{comboBoxStudentId.Text}'");
                DataRow[] selectedProgramsRows = DAL.Programs.GetPrograms().Select($"ProgId = '{comboBoxProgramId.Text}'");
                DataRow[] selectedCourseRows = DAL.Courses.GetCourses().Select($"CId = '{comboBoxCourseId.Text}'");

                textBoxGrade.Enabled = false;
                comboBoxStudentId.Enabled = true;
                comboBoxCourseId.Enabled = true;
                comboBoxProgramId.Enabled = true;

                textBoxStudentName.Text = selectedStudentRows[0]["StName"].ToString();
                textBoxProgramName.Text = selectedProgramsRows[0]["ProgName"].ToString();
                textBoxCourseName.Text = selectedCourseRows[0]["CName"].ToString();

                comboBoxStudentId.SelectedValue = c[0].Cells["StId"].Value;
                comboBoxCourseId.SelectedValue = c[0].Cells["CId"].Value;
                textBoxGrade.Text = "" + c[0].Cells["FinalGrade"].Value;
                assignInitial = new string[] { (string)c[0].Cells["StId"].Value, (string)c[0].Cells["CId"].Value };
            }
            if (((mode == Modes.MODIFY)))
            {
                DataRow[] selectedStudentRows = DAL.Students.GetStudents().Select($"StId = '{comboBoxStudentId.Text}'");
                DataRow[] selectedProgramsRows = DAL.Programs.GetPrograms().Select($"ProgId = '{comboBoxProgramId.Text}'");
                DataRow[] selectedCourseRows = DAL.Courses.GetCourses().Select($"CId = '{comboBoxCourseId.Text}'");

                textBoxGrade.Enabled = false;
                comboBoxStudentId.Enabled = false;
                comboBoxCourseId.Enabled = true;
                comboBoxProgramId.Enabled = false;

                textBoxStudentName.Text = selectedStudentRows[0]["StName"].ToString();
                textBoxProgramName.Text = selectedProgramsRows[0]["ProgName"].ToString();
                textBoxCourseName.Text = selectedCourseRows[0]["CName"].ToString();

                comboBoxStudentId.SelectedValue = c[0].Cells["StId"].Value;
                comboBoxCourseId.SelectedValue = c[0].Cells["CId"].Value;
                textBoxGrade.Text = "" + c[0].Cells["FinalGrade"].Value;
                assignInitial = new string[] { (string)c[0].Cells["StId"].Value, (string)c[0].Cells["CId"].Value };
            }
            if (mode == Modes.ADD)
            {
                DataRow[] selectedStudentRows = DAL.Students.GetStudents().Select($"StId = '{comboBoxStudentId.Text}'");
                DataRow[] selectedProgramsRows = DAL.Programs.GetPrograms().Select($"ProgId = '{comboBoxProgramId.Text}'");
                DataRow[] selectedCourseRows = DAL.Courses.GetCourses().Select($"CId = '{comboBoxCourseId.Text}'");

                textBoxGrade.Enabled = false;
                comboBoxStudentId.Enabled = true;
                comboBoxCourseId.Enabled = true;
                comboBoxProgramId.Enabled = true;

                textBoxStudentName.Text = selectedStudentRows[0]["StName"].ToString();
                textBoxProgramName.Text = selectedProgramsRows[0]["ProgName"].ToString();
                textBoxCourseName.Text = selectedCourseRows[0]["CName"].ToString();
            }
            
            if (mode == Modes.GRADE)
            {
                DataRow[] selectedStudentRows = DAL.Students.GetStudents().Select($"StId = '{comboBoxStudentId.Text}'");
                DataRow[] selectedProgramsRows = DAL.Programs.GetPrograms().Select($"ProgId = '{comboBoxProgramId.Text}'");
                DataRow[] selectedCourseRows = DAL.Courses.GetCourses().Select($"CId = '{comboBoxCourseId.Text}'");

                textBoxGrade.Enabled = true;
                textBoxGrade.ReadOnly = false;
                comboBoxStudentId.Enabled = false;
                comboBoxCourseId.Enabled = false;
                comboBoxProgramId.Enabled = false;

                textBoxStudentName.Text = selectedStudentRows[0]["StName"].ToString();
                textBoxProgramName.Text = selectedProgramsRows[0]["ProgName"].ToString();
                textBoxCourseName.Text = selectedCourseRows[0]["CName"].ToString();
            }

            ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void buttonOkStudentFormEdition_Click(object sender, EventArgs e)
        {
            int r = -1;
            if (mode == Modes.ADD)
            {
                if (comboBoxStudentId.SelectedValue != null && comboBoxCourseId.SelectedValue != null)
                {
                    r = DAL.Enrollments.InsertData(new string[] {
                comboBoxStudentId.SelectedValue.ToString(),
                comboBoxCourseId.SelectedValue.ToString()
            });
                }
                else
                {
                    CollegeSystem.Form1.DALMessage("Please select both student and course.");
                    return; // Interrompe a execução do método se os dados não forem válidos
                }
            }
            if (mode == Modes.MODIFY)
            {
                List<string[]> lId = new List<string[]>();
                lId.Add(assignInitial);

                r = DAL.Enrollments.InsertData(new string[] { (string)comboBoxStudentId.SelectedValue, (string)comboBoxCourseId.SelectedValue, (string)comboBoxProgramId.SelectedValue });

                if (r == 0)
                {
                    r = DAL.Enrollments.DeleteData(lId);
                }
            }
            if (mode == Modes.DELETE)
            {
                List<string[]> lId = new List<string[]>();
                
                if (r == 0)
                {
                    r = DAL.Enrollments.DeleteData(lId);
                }
            }
            if (mode == Modes.GRADE)
            {
                r = BLL.Grade.UpdateGrade(assignInitial, textBoxGrade.Text);
            }

            if (r == 0) { Close(); }
        }

        private void comboBoxStudentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStudentId.SelectedItem != null)
            {
                var a = from r in DAL.Students.GetStudents().AsEnumerable()
                        where r.Field<string>("StId") == (string)comboBoxStudentId.SelectedValue
                        select new { Name = r.Field<string>("StName") };
                textBoxStudentName.Text = a.Single().Name;
            }
        }

        private void comboBoxCourseId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCourseId.SelectedItem != null)
            {
                var a = from r in DAL.Courses.GetCourses().AsEnumerable()
                        where r.Field<string>("CId") == (string)comboBoxCourseId.SelectedValue
                        select new { Name = r.Field<string>("CName") };
                textBoxCourseName.Text = a.Single().Name;
            }
        }
    }
}
