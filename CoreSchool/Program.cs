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

            Console.WriteLine(mySchool);
        }
    }
}
