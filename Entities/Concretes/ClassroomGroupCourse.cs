using Core.Entities;

namespace Entities.Concretes
{
    public class ClassroomGroupCourse : Entity<int>
    {
        public int ClassroomGroupId { get; set; }
        public int CourseId { get; set; }
        public ClassroomGroup ClassroomGroups { get; set; }
        public Course Courses { get; set; }
        

    }
}
