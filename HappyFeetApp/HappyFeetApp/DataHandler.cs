using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyFeetApp
{
    class DataHandler
    {
        //We set the format method
        public List<string> format(List<string> data)
        {
            List<DogDetails> dogs = new List<DogDetails>();
            foreach (string row in data) 
            {
                string[] item = row.Split(',');
                DogDetails dg = new DogDetails(item[0], item[1], item[2],int.Parse(item[3]));
                dogs.Add(dg);
            }

            List<string> formatted = new List<string>();
            //Loop through each dog, and convert using ToString method
            foreach (DogDetails dog in dogs) 
            {
                formatted.Add(dog.ToString());
            }

            return formatted;
        }
    }
}
