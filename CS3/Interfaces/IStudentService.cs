using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS3.DataModel;

namespace CS3.Interfaces
{
    public interface IStudentService : IPersonService
    {
        decimal CalculateGPA();
        int AddCourse(Course course);
        int DeleteCourse(Course course);
        int AddGrade(string grade);
        int DeleteGrade(string grade);
    }
}
