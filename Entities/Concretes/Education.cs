using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Education : Entity<int>
    {
        public int UserId { get; set; }
        public  int EducationDegreeId { get; set; }
        public string SchoolName { get; set; }
        public string Department { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ?EndDate { get; set; }

    }
}
