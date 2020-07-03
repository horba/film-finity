 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;

namespace WebAPI.Repositories
{
    public interface IReviewsRepository : IRepository<Review>
    {
        IQueryable<Review> GetAllReviewsByUserId(int UserId);
    }
}
