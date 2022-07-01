using CS3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3.DataModel
{
    public abstract class Person : IPersonService
    {
        int Id { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        DateTime Birthday { get; set; }
        List<string> Addresses { get; set; }
        public int AddAddress(string addr)
        {
            Addresses.Add(addr);
            return 1;
        }
        public int RemoveAddress(string addr)
        {
            if (Addresses.Contains(addr))
            {
                Addresses.Remove(addr);
                return 1;
            }
            return 0;
        }
        public int CalculateAge()
        {
            return DateTime.Now.Year - Birthday.Year;
        }
        public abstract decimal CalculateSalary();
        public Person()
        {

        }
    }
    public class Student : Person, IStudentService
    {
        List<Course> Courses { get; set; }
        List<string> Grades { get; set; }
        public int AddCourse(Course course)
        {
            Courses.Add(course);
            return 1;
        }
        public int DeleteCourse(Course course)
        {
            if (Courses.Contains(course)) {
                Courses.Remove(course);
                return 1;
            }
            return 0;
        }
        public int AddGrade(string grade)
        {
            Grades.Add(grade);
            return 1;
        }
        public int DeleteGrade(string grade)
        {
            if (Grades.Contains(grade)) {
                Grades.Remove(grade);
                return 1;
            }
            return 0;
        }
        public decimal CalculateGPA()
        {
            int total = 0;
            foreach (string grade in Grades)
            {
                switch (grade)
                {
                    case "A":
                        total += 4;
                        break;
                    case "B":
                        total += 3;
                        break;
                    case "C":
                        total += 2;
                        break;
                    case "D":
                        total += 1;
                        break;
                }
            }
            return (decimal) total / Grades.Count();
        }
        public override decimal CalculateSalary()
        {
            return 0;
        }
        public Student()
        {

        }
    }
    public class Instructor : Person, IInstructorService
    {
        Department Dept { get; set; }
        bool DeptHead { get; set; }
        DateTime StartDate { get; set; }
        public int YearsExperience()
        {
            return DateTime.Now.Year - StartDate.Year;
        }

        public override decimal CalculateSalary()
        {
            int yearsExp = YearsExperience();
            return (decimal) 50000 + yearsExp*1000;
        }
        public Instructor()
        {

        }
    }
}
