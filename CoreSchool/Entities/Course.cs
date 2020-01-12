using System;

namespace CoreSchool.Entities
{
    public class Course
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public JouneyTypes Jouney { get; set; }
        public Course()  => (UniqueId) = (Guid.NewGuid().ToString());
    }
}