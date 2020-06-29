using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTO;
using Entities.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Repositories
{
    public class NewsRepository : Repository<NewsDTO>, INewsRepository
    {

        public NewsRepository(FilmFinityDbContext context)
        : base(context)
        { }

        public IQueryable<News> GetAllNews()
        {
            return _dbContext.News
                .Include(n => n.Author)
                .Include(n => n.NewsCategories)
                    .ThenInclude(n => n.Category);
        }
    }
}
