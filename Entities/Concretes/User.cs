using Core.Entities;

namespace Entities.Concretes
{
    public class User:Entity<int>
    {
        public int RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public List<Instructor> Instructors { get; set; }
        public List<Student> Student { get; set; }
    }
}
