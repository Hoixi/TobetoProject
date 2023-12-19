using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.InstructorRequests
{
    public class UpdateInstructorRequest
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public Course Course { get; set; }
    }
}
