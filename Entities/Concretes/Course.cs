using Core.Entities;

namespace Entities.Concretes
{
    public class Course : Entity<int>
    {
        public int Img_Id { get; set; }
        public string Name { get; set; }
        public  DateTime StartedDate { get; set; }
        
    }
}
