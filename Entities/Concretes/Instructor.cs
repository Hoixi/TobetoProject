using Core.Entities;

namespace Entities.Concretes
{
    public class Instructor:Entity<int>
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public List<CourseInstructor> CourseInstructors { get; set; }
    }
}
