using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class ClassroomStudent:Entity<int>
    {
        public int ClassroomGroupId { get; set; }
        public int StudentId { get; set; }
    }
}
