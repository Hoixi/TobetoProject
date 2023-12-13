using Core.Entities;

namespace Entities.Concretes
{
    public class Course : Entity<int>
    {
        public int ImageId { get; set; }
        public string Name { get; set; }
        public  DateTime StartedDate { get; set; }
        public Image Image { get; set; }
        public List<Instructor> Instructors { get; set; }
        
        
    }
}
