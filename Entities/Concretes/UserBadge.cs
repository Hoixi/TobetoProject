using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class UserBadge : Entity<int>
    {
        public int UserId { get; set; }
        public int BadgeId { get; set; }
        public  User User { get; set; }
        public Badge Badge { get; set; }

    }
}
