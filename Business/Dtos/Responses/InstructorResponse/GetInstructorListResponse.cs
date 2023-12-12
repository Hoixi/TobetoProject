﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.InstructorResponse
{
    public class GetInstructorListResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public string FirstName { get; set; }
        public string CourseName { get; set; }
        
    }
}
