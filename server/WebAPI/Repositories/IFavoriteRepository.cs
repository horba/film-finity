using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTO;

namespace WebAPI.Repositories
{
    public interface IFavoriteRepository : IRepository<FavoriteDTO>
    {
        List<Favorite> GetAllFavorites();
    }
}
