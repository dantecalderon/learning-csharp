using System;
using CoreSchool.Entities;

namespace CoreSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySchool = new CoreSchool.Entities.School("The Umbrella Academy", 1678, SchoolType.PreSchool);
            // mySchool.Country = "USA";
            // mySchool.Type = SchoolType.PreSchool;

            var course1 = new Course() {
                Name = "101"
            };
            var course2 = new Course() {
                Name = "256"
            };
            var course3 = new Course() {
                Name = "512"
            };

            Console.WriteLine(mySchool);
            Console.WriteLine(new String('=', 40));
            Console.WriteLine($"{course1.Name}, {course1.UniqueId}");
            Console.WriteLine($"{course2.Name}, {course2.UniqueId}");
            Console.WriteLine($"{course3.Name}, {course3.UniqueId}");
        }
    }
}
