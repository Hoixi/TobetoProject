using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface ICityDal : IRepository<City, int>, IAsyncRepository<City, int>
{
}
