using Core.Entities;

namespace Entities.Concretes
{
    public class Student:Entity<int>
    {
        public int UserId { get; set; }
        public int StudentNumber { get; set; }
        public List<ClassroomStudent> Classrooms { get; set; }
        public User User { get; set; }
    }
}
