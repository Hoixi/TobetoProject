using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IClassroomDal : IRepository<Classroom,int>,IAsyncRepository<Classroom, int>
{

}
