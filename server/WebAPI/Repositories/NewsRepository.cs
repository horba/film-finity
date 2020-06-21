using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTO;
using Entities.DataAccess;
using WebAPI.Validation;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Repositories
{
    public class NewsRepository
    {
        private readonly FilmFinityDbContext dbContext;

        public NewsRepository(FilmFinityDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IQueryable<News> GetAllNews()
        {
            return dbContext.News
                .Include(n => n.Author)
                .Include(n => n.NewsCategories)
                    .ThenInclude(n => n.Category);
        }
    }
}
