using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DAL
{
    internal class Connect
    {
        private static string collegeConnectionString = GetConnectString();
        internal static string ConnectionString => collegeConnectionString;

        private static string GetConnectString()
        {
            SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
            cs.DataSource = "(local)";
            cs.InitialCatalog = "College1en";
            cs.UserID = "sa";
            cs.Password = "sysadm";
            return cs.ConnectionString;
        }
    }

    internal class DataTables
    {
        private static SqlDataAdapter adapterPrograms = InitAdapterPrograms();
        private static SqlDataAdapter adapterCourses = InitAdapterCourses();
        private static SqlDataAdapter adapterStudents = InitAdapterStudents();
        private static SqlDataAdapter adapterEnrollments = InitAdapterEnrollments();
        private static SqlDataAdapter adapterDisplayEnrollments = InitAdapterDisplayEnrollments();

        private static DataSet ds = InitDataSet();

        private static SqlDataAdapter InitAdapterPrograms()
        {
            var adapter = new SqlDataAdapter("SELECT * FROM Programs ORDER BY ProgId", Connect.ConnectionString);
            var builder = new SqlCommandBuilder(adapter);
            adapter.UpdateCommand = builder.GetUpdateCommand();
            return adapter;
        }

        private static SqlDataAdapter InitAdapterCourses()
        {
            var adapter = new SqlDataAdapter("SELECT * FROM Courses ORDER BY CId", Connect.ConnectionString);
            var builder = new SqlCommandBuilder(adapter);
            adapter.UpdateCommand = builder.GetUpdateCommand();
            return adapter;
        }

        private static SqlDataAdapter InitAdapterStudents()
        {
            var adapter = new SqlDataAdapter("SELECT * FROM Students ORDER BY StId", Connect.ConnectionString);
            var builder = new SqlCommandBuilder(adapter);
            adapter.UpdateCommand = builder.GetUpdateCommand();
            return adapter;
        }

        private static SqlDataAdapter InitAdapterEnrollments()
        {
            var adapter = new SqlDataAdapter("SELECT * FROM Enrollments ORDER BY StId, CId", Connect.ConnectionString);
            var builder = new SqlCommandBuilder(adapter);
            adapter.UpdateCommand = builder.GetUpdateCommand();
            return adapter;
        }

        private static SqlDataAdapter InitAdapterDisplayEnrollments()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(
                "SELECT s.StId, s.StName, c.CId, c.CName, e.FinalGrade " +
                "FROM Enrollments e " +
                "JOIN Students s ON e.StId = s.StId " +
                "JOIN Courses c ON e.CId = c.CId " +
                "ORDER BY s.StId, c.CId",
                Connect.ConnectionString);

            return adapter;
        }

        private static DataSet InitDataSet()
        {
            var ds = new DataSet();
            LoadPrograms(ds);
            LoadCourses(ds);
            LoadStudents(ds);
            LoadEnrollments(ds);
            return ds;
        }

        private static void LoadPrograms(DataSet ds)
        {
            adapterPrograms.Fill(ds, "Programs");
            ds.Tables["Programs"].Columns["ProgId"].AllowDBNull = false;
            ds.Tables["Programs"].Columns["ProgName"].AllowDBNull = false;
            ds.Tables["Programs"].PrimaryKey = new DataColumn[] { ds.Tables["Programs"].Columns["ProgId"] };
        }

        private static void LoadCourses(DataSet ds)
        {
            adapterCourses.Fill(ds, "Courses");
            ds.Tables["Courses"].Columns["CId"].AllowDBNull = false;
            ds.Tables["Courses"].Columns["CName"].AllowDBNull = false;
            ds.Tables["Courses"].PrimaryKey = new DataColumn[] { ds.Tables["Courses"].Columns["CId"] };

            var fkProgCourse = new ForeignKeyConstraint("FK_Prog_Course",
                ds.Tables["Programs"].Columns["ProgId"],
                ds.Tables["Courses"].Columns["ProgId"]);
            fkProgCourse.DeleteRule = Rule.None;
            fkProgCourse.UpdateRule = Rule.Cascade;
            ds.Tables["Courses"].Constraints.Add(fkProgCourse);
        }

        private static void LoadStudents(DataSet ds)
        {
            adapterStudents.Fill(ds, "Students");
            ds.Tables["Students"].Columns["StId"].AllowDBNull = false;
            ds.Tables["Students"].Columns["StName"].AllowDBNull = false;
            ds.Tables["Students"].PrimaryKey = new DataColumn[] { ds.Tables["Students"].Columns["StId"] };

            var fkProgStudent = new ForeignKeyConstraint("FK_Prog_Student",
                ds.Tables["Programs"].Columns["ProgId"],
                ds.Tables["Students"].Columns["ProgId"]);
            fkProgStudent.DeleteRule = Rule.None;
            fkProgStudent.UpdateRule = Rule.Cascade;
            ds.Tables["Students"].Constraints.Add(fkProgStudent);
        }

        private static void LoadEnrollments(DataSet ds)
        {
            adapterEnrollments.Fill(ds, "Enrollments");
            ds.Tables["Enrollments"].Columns["StId"].AllowDBNull = false;
            ds.Tables["Enrollments"].Columns["CId"].AllowDBNull = false;
            ds.Tables["Enrollments"].PrimaryKey = new DataColumn[] { ds.Tables["Enrollments"].Columns["StId"], ds.Tables["Enrollments"].Columns["CId"] };

            var fkStEnroll = new ForeignKeyConstraint("FK_St_Enroll",
                ds.Tables["Students"].Columns["StId"],
                ds.Tables["Enrollments"].Columns["StId"]);
            fkStEnroll.DeleteRule = Rule.Cascade;
            fkStEnroll.UpdateRule = Rule.Cascade;
            ds.Tables["Enrollments"].Constraints.Add(fkStEnroll);

            var fkCourseEnroll = new ForeignKeyConstraint("FK_Course_Enroll",
                ds.Tables["Courses"].Columns["CId"],
                ds.Tables["Enrollments"].Columns["CId"]);
            fkCourseEnroll.DeleteRule = Rule.None;
            fkCourseEnroll.UpdateRule = Rule.Cascade;
            ds.Tables["Enrollments"].Constraints.Add(fkCourseEnroll);
        }

        private static void loadDisplayEnrollments(DataSet ds)
        {
            adapterDisplayEnrollments.Fill(ds, "DisplayEnrollments");

            // =========================================================================  
            /* Foreign Key between DataTables */

            ForeignKeyConstraint myFK01 = new ForeignKeyConstraint("MyFK01",
                new DataColumn[]{
            ds.Tables["Enrollments"].Columns["StId"],
            ds.Tables["Enrollments"].Columns["CId"]
                },
                new DataColumn[] {
            ds.Tables["DisplayEnrollments"].Columns["StId"],
            ds.Tables["DisplayEnrollments"].Columns["CId"]
                }
            );
            myFK01.DeleteRule = Rule.Cascade;
            myFK01.UpdateRule = Rule.Cascade;
            ds.Tables["DisplayEnrollments"].Constraints.Add(myFK01);

            // ========================================================================= 
        }

        internal static DataSet GetDataSet()
        {
            return ds;
        }

        internal static SqlDataAdapter GetAdapterPrograms()
        {
            return adapterPrograms;
        }

        internal static SqlDataAdapter GetAdapterCourses()
        {
            return adapterCourses;
        }

        internal static SqlDataAdapter GetAdapterStudents()
        {
            return adapterStudents;
        }

        internal static SqlDataAdapter GetAdapterEnrollments()
        {
            return adapterEnrollments;
        }

        internal static SqlDataAdapter GetAdapterDisplayEnrollments()
        {
            return adapterDisplayEnrollments;
        }
    }
    internal static class Programs
    {
        private static SqlDataAdapter adapter = DataTables.GetAdapterPrograms();
        private static DataSet ds = DataTables.GetDataSet();

        internal static DataTable GetPrograms()
        {
            return ds.Tables["Programs"];
        }

        internal static int UpdatePrograms()
        {
            if (!ds.Tables["Programs"].HasErrors)
            {
                return adapter.Update(ds.Tables["Programs"]);
            }
            else
            {
                return -1;
            }
        }
    }

    internal static class Courses
    {
        private static SqlDataAdapter adapter = DataTables.GetAdapterCourses();
        private static DataSet ds = DataTables.GetDataSet();

        internal static DataTable GetCourses()
        {
            return ds.Tables["Courses"];
        }

        internal static int UpdateCourses()
        {
            if (!ds.Tables["Courses"].HasErrors)
            {
                return adapter.Update(ds.Tables["Courses"]);
            }
            else
            {
                return -1;
            }
        }
    }

    internal static class Students
    {
        private static SqlDataAdapter adapter = DataTables.GetAdapterStudents();
        private static DataSet ds = DataTables.GetDataSet();

        internal static DataTable GetStudents()
        {
            return ds.Tables["Students"];
        }

        internal static int UpdateStudents()
        {
            if (!ds.Tables["Students"].HasErrors)
            {
                return adapter.Update(ds.Tables["Students"]);
            }
            else
            {
                return -1;
            }
        }
    }

    internal static class Enrollments
    {
        private static SqlDataAdapter adapter = DataTables.GetAdapterEnrollments(); // Certifique-se que getAdapterEnr() retorna um adapter para a tabela Enrollments
        private static DataSet ds = DataTables.GetDataSet();

        private static DataTable displayAssign = null;

        internal static DataTable GetDisplayEnrollments()
        {
            displayAssign = ds.Tables["DisplayEnrollments"];
            return displayAssign;
        }

        internal static int InsertData(string[] a)
        {
            var test = (
                   from enroll in ds.Tables["Enrollments"].AsEnumerable()
                   where enroll.Field<string>("StId") == a[0]
                   where enroll.Field<string>("CId") == a[1]
                   select enroll);
            if (test.Any())
            {
                CollegeSystem.Form1.DALMessage("This enrollment already exists");
                return -1;
            }
            try
            {
                DataRow line = ds.Tables["Enrollments"].NewRow();
                line.SetField("StId", a[0]);
                line.SetField("CId", a[1]);
                //line.SetField("ProgId", a[2]);
                ds.Tables["Enrollments"].Rows.Add(line);

                adapter.Update(ds.Tables["Enrollments"]);

                if (displayAssign != null)
                {
                    var query = (
                           from student in ds.Tables["Students"].AsEnumerable()
                           from course in ds.Tables["Courses"].AsEnumerable()
                           where student.Field<string>("StId") == a[0]
                           where course.Field<string>("CId") == a[1]
                           select new
                           {
                               StId = student.Field<string>("StId"),
                               StName = student.Field<string>("StName"),
                               CId = course.Field<string>("CId"),
                               CName = course.Field<string>("CName"),
                               FinalGrade = line.Field<Nullable<int>>("FinalGrade")
                           });

                    var r = query.Single();
                    displayAssign.Rows.Add(new object[] { r.StId, r.StName, r.CId, r.CName, r.FinalGrade });
                }
                return 0;
            }
            catch (Exception)
            {
                CollegeSystem.Form1.DALMessage("Insertion / Update rejected");
                return -1;
            }
        }

        internal static int UpdateData(string[] a)
        {
            return 0;  //not used
        }

        internal static int DeleteData(List<string[]> lId)
        {
            try
            {
                // Encontra as linhas correspondentes para deletar
                var lines = ds.Tables["Enrollments"].AsEnumerable()
                                .Where(s => lId.Any(x => (x[0] == s.Field<string>("StId") && x[1] == s.Field<string>("CId"))));

                // Deleta as linhas identificadas
                foreach (var line in lines)
                {
                    if (line.Field<int?>("FinalGrade") == null)
                    {
                        line.Delete();  // Deleta a linha somente se FinalGrade for null
                    }
                    else
                    {
                        // Se FinalGrade não for null, exibe uma mensagem e retorna -1
                        CollegeSystem.Form1.DALMessage("Enrollment cannot be deleted because a FinalGrade exists.");
                        return -1;
                    }
                }

                // Atualiza o adaptador e o banco de dados com as alterações
                adapter.Update(ds.Tables["Enrollments"]);

                return 0;
            }
            catch (Exception)
            {
                // Exibe uma mensagem de erro detalhada caso ocorra um problema
                CollegeSystem.Form1.DALMessage("Error");
                return -1;
            }
        }
        internal static int UpdateFinalGrade(string[] a, Nullable<int> finalGrade)
        {
            try
            {
                var line = ds.Tables["Enrollments"].AsEnumerable()
                                    .Where(s =>
                                        (s.Field<string>("StId") == a[0] && s.Field<string>("CId") == a[1]))
                                    .Single();

                line.SetField("FinalGrade", finalGrade);

                adapter.Update(ds.Tables["Enrollments"]);

                if (displayAssign != null)
                {
                    var r = displayAssign.AsEnumerable()
                                    .Where(s =>
                                        (s.Field<string>("StId") == a[0] && s.Field<string>("CId") == a[1]))
                                    .Single();
                    r.SetField("FinalGrade", finalGrade);
                }
                return 0;
            }
            catch (Exception)
            {
                CollegeSystem.Form1.DALMessage("Update / Deletion rejected");
                return -1;
            }
        }
    }
}