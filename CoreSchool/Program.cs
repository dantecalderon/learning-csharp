using System;
using System.Collections.Generic;
using CoreSchool.Entities;
using static System.Console;

namespace CoreSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySchool = new CoreSchool.Entities.School("The Umbrella Academy", 1678, SchoolType.PreSchool);

            mySchool.Courses = new List<Course>(){
                new Course() {
                    Name = "101"
                },
                new Course() {
                    Name = "256"
                },
                new Course {
                    Name = "512" 
                },
                new Course {
                    Name = "990" 
                }
            };

            Course tmp = new Course {
                Name = "Temoral"
            };
            mySchool.Courses.Add(tmp);

            mySchool.Courses.Remove(tmp);

            mySchool.Courses.RemoveAll(Condition);

            WriteLine(mySchool);
            PrintSchoolCourses(mySchool);
        }

    private static bool Condition(Course obj)
    {
        return obj.Name == "990";
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
