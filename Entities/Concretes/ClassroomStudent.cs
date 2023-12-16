using Core.Entities;

namespace Entities.Concretes;

public class ClassroomStudent : Entity<int>
{
    public int ClassroomId { get; set; }
    public int StudentId { get; set; }   
    public Student Student { get; set; }
    public User User { get; set; }
}

/*
 1 - 1 - 1
 2 - 1 - 2
 */
