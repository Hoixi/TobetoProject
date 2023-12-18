using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IClassroomGroupCourseDal:IRepository<ClassroomGroupCourse, int>, IAsyncRepository<ClassroomGroupCourse, int>
{

}
