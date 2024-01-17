using System;
using Core.Entities;

namespace Entities.Concretes
{
	public class Company : Entity<int>
	{
		public string Name { get; set; }
		public string Url { get; set; }
        public List<CourseCompany> CourseCompanies { get; set; }
    }
}

