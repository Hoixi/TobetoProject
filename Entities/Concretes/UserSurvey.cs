﻿using System;
using Core.Entities;

namespace Entities.Concretes
{
	public class UserSurvey : Entity<int>
	{
		public int StudentId { get; set; }
		public int SurveyId { get; set; }

	}
}
