using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_03_05_Management_hospital.Classes
{
    public class Adress
    {
        private string codalPost;
        private string city;
        private int Unit;

        public Adress() { }

        public Adress(string codalPost, string city, int unit)
        {
            this.codalPost = codalPost;
            this.city = city;
            Unit = unit;
        }

        public string CodalPost { get => codalPost; set => codalPost = value; }
        public string City { get => city; set => city = value; }
        public int Unit1 { get => Unit; set => Unit = value; }
    }
}
