using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class ClassroomGroupCourse : Entity<int>
    {
        public int ClassroomGroupId { get; set; }
        public int CourseId { get; set; }
    }
}
