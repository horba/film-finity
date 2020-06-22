using Entities.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly FilmFinityDbContext Context;
        public Repository(FilmFinityDbContext context)
        {
            this.Context = context;
        }

        public List<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }
    }
}
