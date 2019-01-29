using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.models
{
    class Person
    {
        int ID { get; set; }
        string Firstname { get; set; }
        string Lastname { get; set; }
        int Age { get; set; }
        string Department { get; set; }
        string Address { get; set; }

       public Person() : this("", "", 0, "") { }
       public Person(string firstname, string lastname, int age, string department)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Age = age;
            this.Department = department;
        }

        public override string ToString()
        {
            return this.Firstname + "" + this.Lastname + "" + this.Age + "" + this.Department + "";
        }
    }
}
