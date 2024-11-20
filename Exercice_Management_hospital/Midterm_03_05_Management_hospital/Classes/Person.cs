using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_03_05_Management_hospital.Classes
{
    public class Person
    {
        private string id;
        private string givenName;
        private string familyName;
        private DateTime birthDate;
        private Gender genderPerson;
        private Adress adress;
        private string phone;

        public Person() { }

        public Person(string id, string givenName, string familyName, DateTime birthDate, Gender genderPerson, Adress adress, string phone)
        {
            this.id = id;
            this.givenName = givenName;
            this.familyName = familyName;
            this.birthDate = birthDate;
            this.genderPerson = genderPerson;
            this.adress = adress;
            this.phone = phone;
        }

        public string Id { get => id; set => id = value; }
        public string GivenName { get => givenName; set => givenName = value; }
        public string FamilyName { get => familyName; set => familyName = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public Gender GenderPerson { get => genderPerson; set => genderPerson = value; }
        public Adress Adress { get => adress; set => adress = value; }
        public string Phone { get => phone; set => phone = value; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
