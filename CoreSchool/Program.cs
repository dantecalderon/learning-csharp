using System;
using CoreSchool.Entities;
using static System.Console;

namespace CoreSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySchool = new CoreSchool.Entities.School("The Umbrella Academy", 1678, SchoolType.PreSchool);

            mySchool.Courses = new Course[] {
                new Course() {
                    Name = "101"
                },
                new Course() {
                    Name = "256"
                },
                new Course {
                    Name = "512" 
                }
            };
            mySchool = null;

            WriteLine(mySchool);
            PrintSchoolCourses(mySchool);
        }

        private static void PrintSchoolCourses(School school)
        {
            if(school?.Courses != null) {
                WriteLine(new String('=', 40));
                WriteLine($"{school.Name} Courses");
                WriteLine(new String('=', 40));
                foreach (var course in school.Courses)
                {
                    WriteLine($"{course.Name}, {course.UniqueId}");
                }
            }
        }

        private static void PrintCourses(Course[] courses)
        {   
            foreach (var course in courses)
            {
                WriteLine($"{course.Name}, {course.UniqueId}");
            }
        }
    }
}
