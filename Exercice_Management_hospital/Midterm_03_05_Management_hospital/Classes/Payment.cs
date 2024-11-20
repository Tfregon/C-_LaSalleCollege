using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_03_05_Management_hospital.Classes
{
    public class Payment
    {
        int wage;
        public Payment() { }

        public Payment(int wage)
        {
            this.wage = wage;
        }

        public int Wage { get => wage; set => wage = value; }

        public float paymentSalaryTotalAmountWeekly(float hours, string staff)
        {
            if (staff == "Nurse")
            {
                return 35f * hours;
            }
            else if (staff == "Doctor")
            {
                return 40f * hours;
            }
            else if (staff == "Surgeon")
            {
                return 60f * hours;
            }
            return 0;
        }
    }
}
