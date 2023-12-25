using Core.Entities;

namespace Entities.Concretes
{
    public class ClassroomInstructor:Entity<int>
    {
        public int InstructorId { get; set; }
        public int ClassroomId { get; set; }
        public Instructor Instructor { get; set; }
    }
}
