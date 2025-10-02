using Microsoft.EntityFrameworkCore;
using StudentMgm;
using StudentMgm.Models; // Entity models

namespace StudentMgm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                var Students = new Student()
                {
                    StudentID = 1,
                    StudentAge = 12,
                    StudentName = "Tom"
                };

                var Courses = new Course()
                {
                    CourseID = 1,
                    CourseName = "Math",
                    Grade = null,
                    CourseStart = null


                };

                var Enrollments = new Enrollment()
                {
                    EnrollmentId = 1,
                    StudentId = 1,
                    CourseId = 1

                };

                context.Add(Students);
                context.Add(Courses);
                context.Add(Enrollments);

                //needs to be run for changes to be executed
                context.SaveChanges();

                //output the models from the memory database
                var allStudents = context.Students.ToList();
            }
        }
    }
}