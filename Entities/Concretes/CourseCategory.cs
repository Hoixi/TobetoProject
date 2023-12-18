using System;
using Core.Entities;

namespace Entities.Concretes
{
	public class CourseCategory:Entity<int>
	{
		public int CourseId { get; set; }
		public int CategoryId { get; set; }
	}
}

