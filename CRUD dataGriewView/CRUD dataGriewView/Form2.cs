using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD_dataGriewView
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        DataHandler handler = new DataHandler();


        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in handler.DisplayCourse().Rows)
            {
                ListViewItem item = new ListViewItem(dr["CourseID"].ToString());
                item.SubItems.Add(dr["CourseName"].ToString());
                item.SubItems.Add(dr["Description"].ToString());

                listView1.Items.Add(item);
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            txt_CourseID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txt_CourseName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txt_Description.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
        Course course = new Course();
        private void button1_Click(object sender, EventArgs e)
        {
            course.CourseID = txt_CourseID.Text;
            course.CourseName = txt_CourseName.Text;
            course.Description = txt_Description.Text;

            handler.AddCourse(course.CourseID, course.CourseName, course.Description);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            course.CourseID = txt_CourseID.Text;
            course.CourseName = txt_CourseName.Text;
            course.Description = txt_Description.Text;

            handler.UpdateCourse(course.CourseID, course.CourseName, course.Description);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            course.CourseName = txt_CourseName.Text;

            handler.DeleteCourse( course.CourseName);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.Refresh();
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            
        }
    }
}
