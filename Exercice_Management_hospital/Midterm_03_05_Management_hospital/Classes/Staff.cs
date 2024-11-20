using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_03_05_Management_hospital.Classes
{
    public class Staff : Person
    {
        private string education;
        private string certification;
        private string languages;
        private int workingHours;

        public Staff() { }

        public Staff(string education, string certification, string languages, int workingHours)
        {
            this.education = education;
            this.certification = certification;
            this.languages = languages;
            this.workingHours = workingHours;
        }

        public string Education { get => education; set => education = value; }
        public string Certification { get => certification; set => certification = value; }
        public string Languages { get => languages; set => languages = value; }
        public int WorkingHours { get => workingHours; set => workingHours = value; }

        public override string? ToString()
        {
            return Education + " " + "teste";
        }
    }
}
