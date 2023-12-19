using Core.Entities;

namespace Entities.Concretes
{
    public class Education : Entity<int>
    {
        public int UserId { get; set; }
        public  int EducationDegreeId { get; set; }
        public int SchoolNameId { get; set; }
        public string Department { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ?EndDate { get; set; }

    }
}
