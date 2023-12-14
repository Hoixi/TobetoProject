using Core.Entities;

namespace Entities.Concretes;

public class Classroom : Entity<int>
{   
   public int GroupId{ get; set; }
    public string Name { get; set; }
    //public string Group { get; set; }
    public List<Student> Student { get; set; }
    public Group Group { get; set; }
}
