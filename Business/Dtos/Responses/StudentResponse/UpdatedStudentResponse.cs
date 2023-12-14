using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.StudentResponse;

public class UpdatedStudentResponse
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int ClassroomId { get; set; }
    public DateTime UpdatedDate { get; set; }
}
