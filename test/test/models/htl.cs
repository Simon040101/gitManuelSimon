using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.models
{
    class htl
    {
        string Email { get; set; }
        int ID { get; set; }
        string Firstname { get; set; }
        string Lastname { get; set; }
        int Age { get; set; }
        string Department { get; set; }

        public htl() : this("", 0, "", "", 0, "") { }
        public htl(string email, int id, string firstname, string lastname, int age, string department)
        {
            this.Email = email;
            this.ID = id;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Age = age;
            this.Department = department;
        }

        public override string ToString()
        {
            return this.Email + " " + this.Firstname + " " + this.Lastname + " ";
        }


    }
}
