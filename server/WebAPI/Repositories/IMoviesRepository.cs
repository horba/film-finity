using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTO;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public interface IMoviesRepository : IRepository<MovieDTO>
    {
        IQueryable<Movie> GetAllMovies();
        IQueryable<Movie> GetMovieByUserId(int Id);
        Movie GetMovieById(int id);
    }
}
