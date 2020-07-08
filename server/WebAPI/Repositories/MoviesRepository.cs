using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.DataAccess;
using WebAPI.Models;
using WebAPI.DTO;
using Microsoft.EntityFrameworkCore;
using Entities.Models;

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
        public Movie GetMovie(int MovieId)
        {
            return _dbContext.Movies
                //.Include(c => c.Countries)
                .Include(с => с.Genres).ThenInclude(с => с.GenreTitle)
                //.Include(c => c.Directors)
                //.Include(c => c.Produsers)
                //.Include(c => c.Writers)
                .Include(с => с.FilmAgeRating)
                .Include(с => с.VideoFile)
                //.Include(c => c.FramesImageSource)
                .FirstOrDefault(c => c.Id == MovieId);
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
