using Core.Entities;

namespace Entities.Concretes
{
    public class ClassroomGroupCourse : Entity<int>
    {
        public int ClassroomGroupId { get; set; }
        public int CourseId { get; set; }
    }
}
