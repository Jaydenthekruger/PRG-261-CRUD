using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUD_dataGriewView
{
    class DataHandler
    {
        static string connect = @"Data Source=DESKTOP-QEKJG7O\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;";


        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommand command;
        public DataTable DisplayStudents()
        {
            string query = $"SELECT * FROM tbStudent";

            con = new SqlConnection(connect);
            adapter = new SqlDataAdapter(query, con);

            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable DisplayCourse()
        {
            string query = $"SELECT * FROM tbCourse";

            con = new SqlConnection(connect);
            adapter = new SqlDataAdapter(query, con);

            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

        public void Register(int stdID, string n, string s, string c)
        {
            string query = $"INSERT INTO tbStudent VALUES('{stdID}', '{s}', '{n}', '{c}')";

            con = new SqlConnection(connect);
            con.Open();

            command = new SqlCommand(query, con);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Register Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            finally
            {
                con.Close();
            }
        }
        public void AddCourse(string cid, string cn, string d)
        {
            string query = $"INSERT INTO tbCourse VALUES('{cid}', '{cn}', '{d}')";

            con = new SqlConnection(connect);
            con.Open();

            command = new SqlCommand(query, con);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Register Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            finally
            {
                con.Close();
            }
        }
        public void Update(int stdID, string n, string s, string c)
        {


            string query = $"UPDATE tbStudent SET StudentID='{stdID}',Name='{n}', Surname='{s}', CourseID='{c}'WHERE StudentID='{stdID}'";


            con = new SqlConnection(connect);
            con.Open();

            command = new SqlCommand(query, con);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Update Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            finally
            {
                con.Close();
            }
        }

        public void UpdateCourse(string cid, string cn, string d)
        {


            string query = $"UPDATE tbCourse SET CourseID='{cid}', CourseName='{cn}', Description='{d}'WHERE CourseName='{cn}'";


            con = new SqlConnection(connect);
            con.Open();

            command = new SqlCommand(query, con);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Update Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            finally
            {
                con.Close();
            }
        }
        public void Delete(int stdID)
        {
            string query = $"DELETE FROM tbStudent WHERE  StudentID= '{stdID}'";

            con = new SqlConnection(connect);
            con.Open();

            command = new SqlCommand(query, con);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show($"Details Deleted for studentID = {stdID}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            finally
            {
                con.Close();
            }
        }
        public void DeleteCourse(string cn)
        {
            string query = $"DELETE FROM tbCourse WHERE  CourseName= '{cn}'";

            con = new SqlConnection(connect);
            con.Open();

            command = new SqlCommand(query, con);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show($"Details Deleted for CourseName = {cn}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            finally
            {
                con.Close();
            }

        }
    }
}
