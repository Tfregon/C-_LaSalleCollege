using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_03_05_Management_hospital.Classes
{
    public class Doctor : Staff
    {
        private string areaDoc;

        public Doctor() { }

        public Doctor(string areaDoc)
        {
            this.areaDoc = areaDoc;
        }

        public string AreaDoc { get => areaDoc; set => areaDoc = value; }
    }
}
