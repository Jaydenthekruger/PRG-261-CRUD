using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;     //we import this namespace to gain access to MessageBox

namespace HappyFeetApp
{
    class FileHandler
    {
        //Create DataHandler object to access format method
        DataHandler handler = new DataHandler();

        //Write to file
        public void write(List<string> myDog) 
        {
            File.WriteAllLines("file.txt", myDog);
            MessageBox.Show("Data Successfully Written to File");
        }

        //Method to read from file
        public List<string> read() 
        {
            //Create a list
            List<string> data = new List<string>();

            data = File.ReadAllLines("file.txt").ToList();

            //Pass data list to format
            //Return list with formatted data
            return handler.format(data);
        }
    }
}
