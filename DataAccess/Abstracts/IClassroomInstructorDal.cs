using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IClassroomInstructorDal : IRepository<ClassroomInstructor, int>, IAsyncRepository<ClassroomInstructor, int>
{
}
