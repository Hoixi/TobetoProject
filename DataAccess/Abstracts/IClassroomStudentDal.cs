using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IClassroomStudentDal : IRepository<ClassroomStudent, int>, IAsyncRepository<ClassroomStudent, int>
{
}
