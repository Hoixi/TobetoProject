using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface ICertificateDal : IRepository<Certificate, int>, IAsyncRepository<Certificate, int>
{
}
