using System;
using CoreSchool.Entities;

namespace CoreSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySchool = new CoreSchool.Entities.School("The Umbrella Academy", 1678);
            mySchool.Contry = "USA";
            mySchool.Type = SchoolType.PreSchool;

            Console.WriteLine(mySchool);
        }
    }
}
