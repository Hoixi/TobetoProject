using System;
using Core.Entities;

namespace Entities.Concretes
{
	public class Image:Entity<int>
	{
		public string Path { get; set; }
		public List<Course> Course { get; set;}
	}
}

