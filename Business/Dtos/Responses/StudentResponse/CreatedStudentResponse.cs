using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.StudentResponse;

public class CreatedStudentResponse
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int ClassId { get; set; }
}
