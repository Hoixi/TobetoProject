using System;
using Core.Entities;

namespace Entities.Concretes
{
	public class UserAnnouncement:Entity<int>
	{
		public int UserId { get; set; }
		public string AnnouncementId { get; set; }
        public User User { get; set; }
    }
}

