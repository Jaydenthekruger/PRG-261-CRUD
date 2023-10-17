using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_dataGriewView
{
    internal class Students
    {
        private string name, surname, courseID;
        private int studentID;

        public Students(int studentID, string name, string surname, string courseID)
        {
            this.studentID = studentID;
            this.name = name;
            this.surname = surname;
            this.courseID = courseID;
        }

        public int StudentID { get; set; }
        public string  Name { get; set; }
        public string Surname { get; set; }
        public string CourseID { get; set; }

        public Students() { }

    }
}
