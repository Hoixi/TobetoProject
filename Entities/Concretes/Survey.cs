using System;
using Core.Entities;

namespace Entities.Concretes
{
	public class Survey:Entity<int>
	{
		public string Name { get; set; }
		public string Description { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Url { get; set; }
	}
}

