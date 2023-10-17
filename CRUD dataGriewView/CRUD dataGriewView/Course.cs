using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_dataGriewView
{
    internal class Course
    {
        string courseID, courseName, description;

        public Course(string courseID, string courseName, string description)
        {
            this.courseID = courseID;
            this.courseName = courseName;
            this.description = description;
        }

        internal string CourseID { get; set; }
        internal string CourseName { get; set; }
        internal string Description { get; set; }

        public Course() { }
    }
}
