using System;
using Core.Entities;

namespace Entities.Concretes
{
	public class Announcement:Entity<int>
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public List<UserAnnouncement> UserAnnouncements { get; set; }
	}
}

