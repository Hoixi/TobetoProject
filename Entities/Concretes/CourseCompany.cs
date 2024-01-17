using System;
using Core.Entities;

namespace Entities.Concretes
{
	public class CourseCompany:Entity<int>
	{
		public int CourseId { get; set; }
		public int CompanyId { get; set; }
		public Company Company { get; set; }
        public Course Course { get; set; }

    }
}

