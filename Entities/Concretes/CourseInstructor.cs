using Core.Entities;

namespace Entities.Concretes
{
    public class CourseInstructor:Entity<int>
    {
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public Instructor Instructor { get; set; }
    }
}
