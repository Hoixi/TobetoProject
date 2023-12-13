using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.StudentRequests;

public class CreateStudentRequest
{
    public int UserId { get; set; }
    public int ClassId { get; set; }
}
