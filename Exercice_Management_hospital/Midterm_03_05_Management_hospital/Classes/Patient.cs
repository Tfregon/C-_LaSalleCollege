using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_03_05_Management_hospital.Classes
{
    public class Patient : Person
    {
        private DateTime examDate;
        private string doctorName;
        private string nurseName;
        private string examName;
        public Patient() { }

        public Patient(DateTime examDate, string doctorName, string nurseName, string examName)
        {
            this.examDate = examDate;
            this.doctorName = doctorName;
            this.nurseName = nurseName;
            this.examName = examName;
        }

        public DateTime ExamDate { get => examDate; set => examDate = value; }
        public string DoctorName { get => doctorName; set => doctorName = value; }
        public string NurseName { get => nurseName; set => nurseName = value; }
        public string ExamName { get => examName; set => examName = value; }
    }
}
