using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTO;
using Entities.Models;

namespace WebAPI.Repositories
{
    public interface INewsRepository : IRepository<NewsDTO>
    {
       IQueryable<News> GetAllNews();
    }
}
