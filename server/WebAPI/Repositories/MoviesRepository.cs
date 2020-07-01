using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.DataAccess;
using WebAPI.Models;
using WebAPI.DTO;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Repositories
{
    public class MoviesRepository
    {
        private readonly FilmFinityDbContext dbContext;

        public MoviesRepository(FilmFinityDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IQueryable<Movie> GetAllMovies()
        {
           return dbContext.Movies.Include(c => c.ActorsList).ThenInclude(c => c.Actor);                
        }
    }
}
