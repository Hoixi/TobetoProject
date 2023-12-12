using System;
using Core.DataAccess.Repositories;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfImageDal : EfRepositoryBase<Image, int, TobetoContext>
    {
        public EfImageDal(TobetoContext context) : base(context)
        {
        }
    }
}

