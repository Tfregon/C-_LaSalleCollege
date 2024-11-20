using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_03_05_Management_hospital.Classes
{
    public class Nurse : Staff
    {
        float areaNurse;
        
        public Nurse() { }

        public Nurse(float areaNurse)
        {
            this.areaNurse = areaNurse;
        }

        public float AreaNurse { get => areaNurse; set => areaNurse = value; }
    }
}
