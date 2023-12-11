using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Role:Entity<int>
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }
}
