using CoreSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

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
            LoadCourses();  
            LoadSubjects();
            GenerateExams();
        }

    private List<Student> GenerateStudents(int size = 10)
    {
        string[] firstName1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
        string[] lastName1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" }; 
        string[] firstName2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" }; 

        var studentsList = from f1 in firstName1
                            from f2 in  firstName2
                            from l1 in  lastName1
                            select new Student { Name = $"{f1} {f2} {l1}"};
        return studentsList.OrderBy((al) => al.UniqueId).Take(size).ToList();
        
    }

    private void LoadSubjects()
    {
      foreach (var course in School.Courses)
      {
        var asignaturesList = new List<Subject>()
        {
            new Subject { Name = "Math" },
            new Subject { Name = "Physics" },
            new Subject { Name = "Spanish" },
            new Subject { Name = "Programming" },
            new Subject { Name = "Tusa" },
        };
        course.Subjects = asignaturesList;
          
      }
    }


    private void LoadCourses()
        {
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
            Random rnd = new Random();


            foreach (var course in School.Courses)
            {
                int cantRandom = rnd.Next(5, 20);
                 course.Students = GenerateStudents(cantRandom);
            }
        }
        
        private void GenerateExams()
        {
             Random rnd = new Random();
             int[] cantityExamsArray = { 1, 2, 3, 4, 5 };

            foreach (var course in School.Courses)
            {
               var exams = from student in course.Students
                          from subject in  course.Subjects
                          from examNumber in cantityExamsArray
                          select new Exam() {
                                Name = $"{course.Name} ({subject.Name}) - Exam  #{examNumber}", 
                                Student = student,
                                Subject = subject,
                                Score = float.Parse((rnd.NextDouble()/2).ToString().Substring(0, 3))
                              };
                course.Exams = exams.ToList();

            }
        }
    }

}