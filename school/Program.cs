using System;

namespace school
{
    class School {
        public string name;
        public string address;
        public int foundationYear;

        public void Beep()
        {
            Console.Beep();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var mySchool = new School();

            mySchool.name = "Umbrella Academy";
            mySchool.address = "4 King St E in Hamilton";
            mySchool.foundationYear = 1678;

            Console.WriteLine("BEEP");
            mySchool.Beep();
        }
    }
}
