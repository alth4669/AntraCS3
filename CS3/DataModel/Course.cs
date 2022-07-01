using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS3.Interfaces;

namespace CS3.DataModel
{
    public class Course : ICourseService
    {
        int Id { get; set; }
        string Name { get; set; }
        Instructor Instructor { get; set; }
        List<Student> Enrollment { get; set; }

        public int AddStudent(CS3.DataModel.Student student)
        {
            Enrollment.Add(student);
            return 1;
        }

        public int RemoveStudent(CS3.DataModel.Student student)
        {
            if (Enrollment.Contains(student))
            {
                Enrollment.Remove(student);
                return 1;
            }
            return 0;
        }
        public Course()
        {

        }
    }
}
