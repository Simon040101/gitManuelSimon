using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.models
{
    enum Gender
    {
        male, female, notSpecified
    }

    enum Birthmonth
    {
        january, february, march, april
    }
    class Person
    {
        string Email { get; set; }
        int ID { get; set; }
        string Firstname { get; set; }
        string Lastname { get; set; }
        int Age { get; set; }
        string Department { get; set; }
        string Address { get; set; }
        Gender Gender { get; set; }
        Birthmonth Month { get; set; }
        int Telnumber { get; set; }

       public Person() : this("", "", "", 0, Gender.notSpecified, Birthmonth.march, "", 0) { }
       public Person(string firstname, string lastname, string email, int age, Gender gender, Birthmonth birth, string department, int telnumber)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Age = age;
            this.Gender = gender;
            this.Email = email;
            this.Department = department;
            this.Telnumber = telnumber;
        }


        public override string ToString()
        {
            return this.ID + " " + this.Firstname + " " + this.Lastname + " " + this.Age + " " + this.Gender + " " + this.Month + " " + this.Department + " " + this.Email;
        }
    }
}
