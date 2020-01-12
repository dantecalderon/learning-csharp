using System;

namespace CoreSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySchool = new CoreSchool.Entities.School("The Umbrella Academy", 1678);
            mySchool.Contry = "USA";

            Console.WriteLine("El nombre de la escuela es: " + mySchool.Name);
        }
    }
}
