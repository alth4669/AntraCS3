using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS3.Interfaces;

namespace CS3.DataModel
{
    public class Department : IDepartmentService
    {
        int Id { get; set; }
        string Name { get; set; }
        Instructor Head { get; set; }
        decimal Budget { get; set; }
        List<Course> Courses { get; set; }

        public int AddCourse(Course course)
        {
            Courses.Add(course);
            return 1;
        }

        public int RemoveCourse(Course course)
        {
            if (Courses.Contains(course))
            {
                Courses.Remove(course);
                return 1;
            }
            return 0;
        }
        public Department()
        {

        }
    }
}
