using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.models
{
    class Person
    {
        string Firstname { get; set; }
        string Lastname { get; set; }
        int Age { get; set; }
        string Department { get; set; }

       public Person() : this("", "", 0) { }
       public Person(string firstname, string lastname, int age)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Age = age;
        }

        public override string ToString()
        {
            return this.Firstname + "" + this.Lastname + "" + this.Age + "";
        }
    }
}
