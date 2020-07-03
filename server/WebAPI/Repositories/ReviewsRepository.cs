using Entities.DataAccess;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTO;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public class ReviewsRepository : Repository<ReviewDTO>, IReviewsRepository
    {
        public ReviewsRepository(FilmFinityDbContext context)
         : base(context)
        { }

        public IQueryable<Review> GetAllReviewsByUserId(int UserId)
        {
            return _dbContext.Reviews
                .Where(r => r.UserId == UserId);
        }
        List<Review> IRepository<Review>.GetAll()
        {
            return _dbContext.Reviews.ToList();
        }
    }
}
