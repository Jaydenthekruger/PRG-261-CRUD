using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyFeetApp
{
    internal class DataHandler
    {
        //We set the format method
        public List<string> format(List<string> data)
        {
            List<DogDetails> dogs = new List<DogDetails>();
            foreach (string row in data)
            {
                string[] ithems = row.Split(',');
                DogDetails dg = new DogDetails(ithems[0], ithems[1], ithems[2],int.Parse(ithems[3]));
                dogs.Add(dg);   
            }

            List<string> formatted = new List<string>();
            //Loop throuht each dog, and convert using ToString method
            foreach (DogDetails dg in dogs)
            {
                formatted.Add(dogs.ToString()); 
            }

            return formatted;   
        }
    }
}
