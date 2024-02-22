using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Badge : Entity<int>
    {
        public int ImageId { get; set; }
        public string Name { get; set; }
        public Image Image { get; set; }
        public List<UserBadge> UserBadges { get; set;}
        
    }
}
