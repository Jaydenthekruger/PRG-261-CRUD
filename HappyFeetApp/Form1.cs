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
        BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            bs.DataSource = myDog;
            listBox1.DataSource = bs;   
        }

        
        private void btn_Add_Click(object sender, EventArgs e)
        {
            //Add details from textboxes
            DogDetails dog = new DogDetails(txt_DogName.Text, txt_Name.Text, txt_Surname.Text, int.Parse(txt_Phone.Text));

            myDog.Add(dog.Display());
            bs.ResetBindings(false);   //refreshes the listbox to new values
        }


        FileHandler fh = new FileHandler();
        private void btn_File_from_details_Click(object sender, EventArgs e)
        {
            //Invoking write method, pass it a list of dogs 
            fh.write(myDog);    
        }

        private void btn_details_from_file_Click(object sender, EventArgs e)
        {
            listBox2.DataSource = fh.Read();
        }
    }
}
