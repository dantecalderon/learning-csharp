using System;
using CoreSchool.Entities;

namespace CoreSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySchool = new CoreSchool.Entities.School("The Umbrella Academy", 1678, SchoolType.PreSchool);

            var courses = new Course[3];

            courses[0] = new Course() {
                Name = "101"
            };

            courses[1] = new Course() {
                Name = "256"
            };

            courses[2] = new Course {
                Name = "512"
            };

            Console.WriteLine(mySchool);
            Console.WriteLine(new String('=', 40));
            PrintCourses(courses);
        }

        private static void PrintCourses(Course[] courses)
        {   
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Name}, {course.UniqueId}");
            }
        }
    }
}
