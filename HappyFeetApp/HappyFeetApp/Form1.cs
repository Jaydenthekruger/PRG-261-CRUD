using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyFeetApp
{
    public partial class Form1 : Form
    {
        List<string> myDog = new List<string>();
        //Create object of BindingSource
        BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            //Set global datasource to get bvalues from myDog list
            bs.DataSource = myDog;
            listBox1.DataSource = bs;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
                //Add details from textboxes
            DogDetails dog = new DogDetails(textBox1.Text, textBox2.Text, textBox3.Text, int.Parse(textBox4.Text));

            //this will return a string of each dog entered
            //Add each dog to a list
            myDog.Add(dog.Display());
            bs.ResetBindings(false);        //refreshes the listbox to new values
        }

        FileHandler fh = new FileHandler();
        private void button2_Click(object sender, EventArgs e)
        {
            //Invoking write method, pass it a list of dogs to write to file
            fh.write(myDog);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.DataSource = fh.read();
        }
    }
}
