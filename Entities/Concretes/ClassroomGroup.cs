using Core.Entities;

namespace Entities.Concretes;

public class ClassroomGroup : Entity<int>
{
  
    public int ClassroomId { get; set; }
    public int GroupId { get; set; }
    public  Group Group { get; set; }
    public Classroom Classroom { get; set; }
    public List<ClassroomGroupCourse> ClassroomGroupCourses { get; set; }
    public List<ClassroomStudent> ClassroomStudents { get; set; }
}
