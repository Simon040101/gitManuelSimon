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
        string email { get; set; }
        int ID { get; set; }
        string Firstname { get; set; }
        string Lastname { get; set; }
        int Age { get; set; }
        string Department { get; set; }
        string Address { get; set; }
        Gender Gender { get; set; }
        Birthmonth Month { get; set; }

        public Person() : this("", "", 0, Gender.notSpecified, Birthmonth.march, "") { }
       public Person(string firstname, string lastname, int age, Gender gender, Birthmonth birth, string department)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Age = age;
            this.Gender = gender;
            this.Month = birth;
            this.Department = department;
        }

        public override string ToString()
        {
            return this.ID + " " + this.Firstname + " " + this.Lastname + " " + this.Age + " " + this.Gender + " " + this.Month + " " + this.Department;
        }
    }
}
