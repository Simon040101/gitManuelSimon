using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.models
{
    class Address
    {
        String City { set; get; }
        String Street { get; set; }
        int Nr { get; set; }

        public Address() : this("", "", 0) { }
        public Address(string city, string street, int nr)
        {
            this.City = city;
            this.Street = street;
            this.Nr = nr;
        }
    }
}
