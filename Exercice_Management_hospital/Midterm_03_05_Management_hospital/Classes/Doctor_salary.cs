using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_03_05_Management_hospital.Classes
{
    public class Doctor_salary : Payment
    {
        private float hoursDoc;
        public Doctor_salary() { }

        public Doctor_salary(float salaryDoc)
        {
            this.hoursDoc = salaryDoc;
        }

        public float HoursDoc { get => hoursDoc; set => hoursDoc = value; }

        public float paymentOverTimeDoctor(float hoursDoc)
        {
            float newSalary = paymentSalaryTotalAmountWeekly(hoursDoc, "Surgeon") * 1.2f;
            return newSalary;
        }
    }
}
