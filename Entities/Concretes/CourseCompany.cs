using System;
using Core.Entities;

namespace Entities.Concretes
{
	public class CourseCompany:Entity<int>
	{
		public int CourseId { get; set; }
		public int CompanyId { get; set; }
	}
}

