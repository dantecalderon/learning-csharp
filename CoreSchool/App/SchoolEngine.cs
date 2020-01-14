using CoreSchool.Entities;
using System.Collections.Generic;

namespace CoreSchool
{
    public class SchoolEngine
    {
        public School School { get; set; }

        public SchoolEngine()
        {
        }

        public void Init()
        {
            School = new School("The Umbrella Academy", 1678, SchoolType.PreSchool);

            School.Courses = new List<Course>()
            {
                new Course() {
                    Name = "101",
                    Jouney = JouneyTypes.Afternoon
                },
                new Course() {
                    Name = "256",
                    Jouney = JouneyTypes.Morning
                },
                new Course {
                    Name = "512",
                    Jouney = JouneyTypes.Morning
                },
                new Course {
                    Name = "889",
                    Jouney = JouneyTypes.Night
                }
            };
        }
    }
}