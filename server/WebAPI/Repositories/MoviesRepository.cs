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
    public class MoviesRepository : Repository<MovieDTO>, IMoviesRepository
    {
        
        public MoviesRepository(FilmFinityDbContext context)
            : base(context)
        { }
        
        public IQueryable<Movie> GetAllMovies()
        {
           return _dbContext.Movies.Include(c => c.ActorsList).ThenInclude(c => c.Actor);                
        }
        
        public Movie GetMovieById(int id)
        {
            return _dbContext.Movies
                .Include(c => c.ActorsList)
                .ThenInclude(c => c.Actor)
                .Where(x => x.Id == id)
                .First();
        }
    }
}
