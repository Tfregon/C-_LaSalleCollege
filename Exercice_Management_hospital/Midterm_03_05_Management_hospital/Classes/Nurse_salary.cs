using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_03_05_Management_hospital.Classes
{
    public class Nurse_salary : Payment
    {
        int hoursNurse;

        public Nurse_salary() { }

        public Nurse_salary(int hoursNurse)
        {
            this.hoursNurse = hoursNurse;
        }

        public int HoursNurse { get => hoursNurse; set => hoursNurse = value; }

        public float paymentOverTimeNurse(float hoursNurse)
        {
            float newSalary = paymentSalaryTotalAmountWeekly(hoursNurse, "Nurse") * 1.15f;
            return newSalary;
        }
    }
}
