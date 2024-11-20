using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_03_05_Management_hospital.Classes
{
    public class Gender
    {
        string genderType;
        public Gender() { }

        public Gender(string genderType)
        {
            this.genderType = genderType;
        }

        public string GenderType { get => genderType; set => genderType = value; }
    }
}
