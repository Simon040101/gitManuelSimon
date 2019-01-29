using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.models
{
    class Car
    {
        int ID { get; set; }
        string Brand { get; set; }
        int Nr { get; set; }


        public Car() : this(0, "", 0) { }
        public Car(int id, string brand, int nr)
        {
            this.ID = id;
            this.Brand = brand;
            this.Nr = nr;
        }

        public override string ToString()
        {
            return this.ID + "" + this.Brand + "" + this.Nr + "";
        }
    }
}
