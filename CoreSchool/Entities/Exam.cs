using System;

namespace CoreSchool.Entities
{
    public class Exam
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        public float Score { get; set; }
        public Exam() => (UniqueId) = Guid.NewGuid().ToString();
    }
}