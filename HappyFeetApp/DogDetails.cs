using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyFeetApp
{
    internal class DogDetails
    {
        internal string dogname { get; set; }   
        internal string name { get; set; }
        internal string surname { get; set; }
        internal int phone { get; set; }   

        public DogDetails(string dogname, string name, string surname, int phone)
        {
            this.dogname = dogname;
            this.name = name;
            this.surname = surname;
            this.phone = phone;
        }   

        public DogDetails() { }

        public string Display()
        {
            return $"{this.dogname}, {this.name}, {this.surname}, {this.phone}";
        }

        public override string ToString()
        {
            return $" Dog Name: {this.dogname}  |  Owner Name: {this.name}  |  Owner Surname: {this.surname}  |  Phone: {this.phone}";
        }
    }
}
