﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.ClassroomGroupCourseResponses
{
    public class GetListClassroomGroupCourseResponse
    {
        public int Id { get; set; }
        public string ClassroomGroupName { get; set; }
        public string CourseName { get; set; }
    }
}
