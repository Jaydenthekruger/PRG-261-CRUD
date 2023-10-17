using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyFeetApp
{
    class DogDetails
    {
        //Fields and properties
        internal string dogname { get; set; }
        internal string ownername { get; set; }
        internal string surname { get; set; }
        internal int phone { get; set; }

        //default constructor
        public DogDetails() { }
        //parameterized constructor
        public DogDetails(string dn, string n, string s, int p)
        {
            this.dogname = dn;
            this.ownername = n;
            this.surname = s;   
            this.phone = p;
        }

        //Display method
        public string Display()
        {
            return $"{this.dogname},{this.ownername}, {this.surname}, {this.phone}";
        }

        public override string ToString()
        {
            return $"Dog Name: {this.dogname} | Owner Name: {this.ownername} | Owner Surname: {this.surname}, | Phone: {this.phone}";
        }
    }
}
