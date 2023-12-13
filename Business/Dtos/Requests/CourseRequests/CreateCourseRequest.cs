﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.CourseRequests
{
    public class CreateCourseRequest
    {
        public int ImageId { get; set; }
        public string Name { get; set; }
        public DateTime StartedDate { get; set; }

    }
}
