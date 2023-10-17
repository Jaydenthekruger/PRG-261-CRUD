using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CRUD_dataGriewView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataHandler handler = new DataHandler();

        BindingSource src = new BindingSource();

        private void button1_Click(object sender, EventArgs e)
        {
            src.MoveFirst();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            src.DataSource = handler.DisplayStudents();
            dataGridView1.DataSource = src;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            src.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            src.MovePrevious();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            src.MoveLast();
        }
        Students student = new Students();
        DataHandler hl = new DataHandler();
        private void button4_Click(object sender, EventArgs e)
        {
           student.StudentID = int.Parse(txt_StudentID.Text);
           student.Name = txt_Name.Text;
           student.Surname = txt_Surname.Text;
           student.CourseID = txt_Course.Text;

           hl.Register(student.StudentID, student.Name, student.Surname, student.CourseID);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            student.StudentID = int.Parse(txt_StudentID.Text);
            student.Name = txt_Name.Text;
            student.Surname = txt_Surname.Text;
            student.CourseID = txt_Course.Text;

            handler.Update(student.StudentID, student.Name, student.Surname, student.CourseID);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Students student = new Students();
            student.StudentID = int.Parse(txt_StudentID.Text);

            DataHandler handler = new DataHandler();

            handler.Delete(student.StudentID);
        }
      
        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.DisplayStudents();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;

                txt_StudentID.Text = dataGridView1.Rows[e.RowIndex].Cells["StudentID"].FormattedValue.ToString();
                txt_Name.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                txt_Surname.Text = dataGridView1.Rows[e.RowIndex].Cells["Surname"].FormattedValue.ToString();
                txt_Course.Text = dataGridView1.Rows[e.RowIndex].Cells["CourseID"].FormattedValue.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
