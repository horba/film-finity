using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Repositories;
using WebAPI.DTO;
using AutoMapper;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly IMapper _mapper;
        private readonly IMoviesRepository _moviesRepository;

        public MoviesService(IMoviesRepository _moviesRepository, IMapper _mapper)
        {
            this._mapper = _mapper;
            this._moviesRepository = _moviesRepository;
        }
        public IEnumerable<MovieDTO> GetAllMovies()
        {
            var movies = _moviesRepository.GetAllMovies();
            return _mapper.Map<IEnumerable<Movie>, IEnumerable < MovieDTO >> (movies.ToList());
        }
        public MovieDTO GetMovieByUserId(int Id)
        {
            var movie = _moviesRepository.GetMovieByUserId(Id).Single();
            return _mapper.Map<Movie, MovieDTO>(movie);
        }
        public MovieDTO GetMovieById(int id)
        {
            var movie = _moviesRepository.GetMovieById(id);
            return _mapper.Map<MovieDTO>(movie);
        }
    }
}
