using System;
using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfImageDal : EfRepositoryBase<Image, int, TobetoContext>,IImageDal
    {
        public EfImageDal(TobetoContext context) : base(context)
        {
        }
    }
}

