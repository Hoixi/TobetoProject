using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IEducationDal : IRepository<Education, int>, IAsyncRepository<Education, int>
{
}