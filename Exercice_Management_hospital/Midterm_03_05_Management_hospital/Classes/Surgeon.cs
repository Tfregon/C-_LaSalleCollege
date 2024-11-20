using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_03_05_Management_hospital.Classes
{
    public class Surgeon : Doctor
    {
        float hoursSurgeon;

        public Surgeon() { }

        public Surgeon(float hoursSurgeon)
        {
            this.hoursSurgeon = hoursSurgeon;
        }
        public float HoursSurgeon { get => hoursSurgeon; set => hoursSurgeon = value; }
    }
}
