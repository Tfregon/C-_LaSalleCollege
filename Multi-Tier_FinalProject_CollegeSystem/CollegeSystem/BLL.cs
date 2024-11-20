using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class ProgramsBLL
    {
        public static int UpdatePrograms()
        {
            DataSet ds = DAL.DataTables.GetDataSet();
            DataTable dt = ds.Tables["Programs"].GetChanges(DataRowState.Added | DataRowState.Modified);

            if (dt != null)
            {
                if (dt.AsEnumerable().Any(r => !IsValidProgId(r.Field<string>("ProgId"))))
                {
                    ShowMessage("Invalid Program ID format.");
                    ds.RejectChanges();
                    return -1;
                }
                else
                {
                    return DAL.Programs.UpdatePrograms();
                }
            }
            return DAL.Programs.UpdatePrograms();
        }

        private static bool IsValidProgId(string progId)
        {
            return progId.Length == 5 && progId.StartsWith("P") && progId.Substring(1).All(char.IsDigit);
        }

        private static void ShowMessage(string message)
        {
            // Método genérico para exibir mensagens
            Console.WriteLine(message);
        }
    }

    public class CoursesBLL
    {
        public static int UpdateCourses()
        {
            DataSet ds = DAL.DataTables.GetDataSet();
            DataTable dt = ds.Tables["Courses"].GetChanges(DataRowState.Added | DataRowState.Modified);

            if (dt != null)
            {
                if (dt.AsEnumerable().Any(r => !IsValidCourseId(r.Field<string>("CId"))))
                {
                    ShowMessage("Invalid Course ID format.");
                    ds.RejectChanges();
                    return -1;
                }

                // Verifica se cada curso pertence a apenas um programa
                var duplicatePrograms = dt.AsEnumerable()
                    .GroupBy(r => r.Field<string>("CId"))
                    .Where(g => g.Select(r => r.Field<string>("ProgId")).Distinct().Count() > 1);

                if (duplicatePrograms.Any())
                {
                    ShowMessage("Cada curso deve pertencer a apenas um programa.");
                    ds.RejectChanges();
                    return -1;
                }

                return DAL.Courses.UpdateCourses();
            }
            return DAL.Courses.UpdateCourses();
        }

        private static bool IsValidCourseId(string courseId)
        {
            return courseId.Length == 7 && courseId.StartsWith("C") && courseId.Substring(1).All(char.IsDigit);
        }

        private static void ShowMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public class StudentsBLL
    {

        public static int UpdateStudents()
        {
            DataSet ds = DAL.DataTables.GetDataSet();
            DataTable dt = ds.Tables["Students"].GetChanges(DataRowState.Added | DataRowState.Modified);

            if (dt != null)
            {
                if (dt.AsEnumerable().Any(r => !IsValidStudentId(r.Field<string>("StId"))))
                {
                    ShowMessage("Invalid Student ID format.");
                    ds.RejectChanges();
                    return -1;
                }
                else
                {
                    return DAL.Students.UpdateStudents();
                }
            }
            return DAL.Students.UpdateStudents();
        }

        private static bool IsValidStudentId(string studentId)
        {
            return studentId.Length == 10 && studentId.StartsWith("S") && studentId.Substring(1).All(char.IsDigit);
        }

        private static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class EnrollmentsBLL
    {
        public static int UpdateEnrollments()
        {
            DataSet ds = DAL.DataTables.GetDataSet();
            DataTable dt = ds.Tables["Enrollments"].GetChanges(DataRowState.Added | DataRowState.Modified);

            if (dt != null)
            {
                if (dt.AsEnumerable().Any(r => !IsValidStudentId(r.Field<string>("StId"))))
                {
                    ShowMessage("Invalid Student ID format.");
                    ds.RejectChanges();
                    return -1;
                }
            }
            return DAL.Students.UpdateStudents();
        }

        private static bool IsValidStudentId(string studentId)
        {
            return studentId.Length == 10 && studentId.StartsWith("S") && studentId.Substring(1).All(char.IsDigit);
        }

        private static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Grade
    {
        internal static int UpdateGrade(string[] a, string ev)
        {
            Nullable<int> grade;
            int temp;

            if (ev == "")
            {
                grade = null;
            }
            else if (int.TryParse(ev, out temp) && (0 <= temp && temp <= 100))
            {
                grade = temp;
            }
            else
            {
                CollegeSystem.Form1.BLLMessage(
                          "Grade must be an integer between 0 and 100"
                          );
                return -1;
            }

            return DAL.Enrollments.UpdateFinalGrade(a, grade);
        }
    }
}
