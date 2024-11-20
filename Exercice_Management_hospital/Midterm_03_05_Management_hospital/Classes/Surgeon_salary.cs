using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_03_05_Management_hospital.Classes
{
    public class Surgeon_salary : Payment
    {
        private float hoursSurgeon;

        public Surgeon_salary() { }

        public Surgeon_salary(float hoursSurgeon)
        {
            this.hoursSurgeon = hoursSurgeon;
        }

        public float HoursSurgeon { get => hoursSurgeon; set => hoursSurgeon = value; }

        public float paymentOverTimeSurgeon(float hoursSurgeon)
        {
            float newSalary = paymentSalaryTotalAmountWeekly(hoursSurgeon, "Surgeon") * 1.1f;
            return newSalary;
        }
    }
}
