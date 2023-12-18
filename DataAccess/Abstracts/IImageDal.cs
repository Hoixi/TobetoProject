using System;
using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IImageDal : IRepository<Image, int>, IAsyncRepository<Image, int>
    {

	}
}

