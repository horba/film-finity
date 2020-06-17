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
    public class NewsRepository
    {
        private readonly FilmFinityDbContext dbContext;

        public NewsRepository(FilmFinityDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IQueryable<NewsDTO> GetAllNews()
        {
            return dbContext.News
                .Select(row =>
                    new NewsDTO { 
                        NewsId = row.NewsId, 
                        NewsTitle = row.NewsTitle, 
                        NewsContent = row.NewsContent,
                        CountViews = row.CountViews,
                        ImageSource = row.ImageSource,
                        PublishTime = row.PublishTime,
                        Author = new AuthorDTO { AuthorId = row.Author.AuthorId, AuthorName = row.Author.AuthorName },
                        CelebrityJobTitles = row.NewsCategories.Select(j => j.Category)
                            .Select(j => new CategoryDTO { CategoryId = j.CategoryId, CategoryName = j.CategoryName }).ToList()
        });
        }
    }
}
