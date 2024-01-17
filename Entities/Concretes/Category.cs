using System;
using Core.Entities;

namespace Entities.Concretes
{
	public class Category: Entity<int>
	{
		public string Name { get; set; }
        public List<CourseCategory> CourseCategories { get; set; }

    }
}


