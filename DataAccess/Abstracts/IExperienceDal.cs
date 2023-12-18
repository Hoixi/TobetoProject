using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IExperinceDal : IRepository<Experience, int>, IAsyncRepository<Experience, int>
{
}
