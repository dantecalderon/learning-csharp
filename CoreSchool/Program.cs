using System;
using CoreSchool.Entities;
using static System.Console;

namespace CoreSchool
{
    class Program
    {
        static void Main(string[] args)
        {
        
           var engine = new SchoolEngine();
           engine.Init();

           PrintSchoolCourses(engine.School);

         
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
