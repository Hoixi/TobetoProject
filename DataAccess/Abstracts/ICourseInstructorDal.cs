using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface ICourseInstructorDal : IRepository<CourseInstructor, int>, IAsyncRepository<CourseInstructor, int>
{

}
