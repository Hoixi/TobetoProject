using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IClassroomGroupDal : IRepository<ClassroomGroup, int>, IAsyncRepository<ClassroomGroup, int>
{
}