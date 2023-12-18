using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IEducationDegreeDal : IRepository<EducationDegree, int>, IAsyncRepository<EducationDegree, int>
{

}
