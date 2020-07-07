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
    public class FavoriteRepository : Repository<FavoriteDTO>, IFavoriteRepository
    {
        public FavoriteRepository(FilmFinityDbContext context)
            : base(context)
        { }

        public List<Favorite> GetAllFavorites()
        {
            return _dbContext.Favorites.ToList();
        }
    }
}
