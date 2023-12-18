using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface ICourseDal : IRepository<Course, int>, IAsyncRepository<Course, int>
{

}
