using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace HappyFeetApp
{
    internal class FileHandler
    {
   
        //Write to file
        public void write(List<string> myDog)
        {
            File.WriteAllLines("dogdetails.txt", myDog);
            MessageBox.Show("Data Successfully Written to File");
        }

        //Method to read from file

        //Create DataHandler objects to acess format method
        DataHandler dh = new DataHandler(); 
        public List<string> Read()
        {
            //Create a list
            List<string> data = new List<string>();

            data = File.ReadAllLines("dogdetails.txt").ToList();
            return dh.format(data);    
        }
    }
}
