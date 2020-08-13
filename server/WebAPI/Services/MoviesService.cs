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

        public MovieDTO GetMovieById(int id)
        {
            var movie = _moviesRepository.GetMovieById(id);
            return _mapper.Map<MovieDTO>(movie);
        }

        public MovieDetailsDTO GetMovieDetails(int MovieId)
        {
            Random rand = new Random();
            var movie = _moviesRepository.GetMovie(MovieId);
            MovieDetailsDTO movieDTO = new MovieDetailsDTO
            {
                Id = movie.Id,
                Title = movie.Title,
                OriginalTitle = movie.OriginalTitle,
                Countries = new List<string> { { "США" } },
                DurationMinutes = movie.DurationMinutes,
                Rate = movie.Rate,
                Rates = new Dictionary<string, double>
                {
                    { "directionRate", Math.Round(rand.NextDouble() * 5, 2) },
                    { "storyRate", Math.Round(rand.NextDouble() * 5, 2) },
                    { "actionRate", Math.Round(rand.NextDouble() * 5, 2) },
                    { "actorsRate", Math.Round(rand.NextDouble() * 5, 2) },
                },
                ReleaseYear = movie.ReleaseYear,
                PosterImageSource = movie.PosterImageSource,
                Description = movie.Description,
                Genres = movie.Genres.Select(g => g.GenreTitle).Select(g => new GenreDTO
                { Id = g.Id, Name = g.Name }).ToList(),
                Directors = new List<string> { { "Грета Гервиг" } },
                Produsers = new List<string> { { "Арнон Милчэн" }, { "Денис Ди Нови" }, { "Эми Паскаль" } },
                Writers = new List<string> { { "Грета Гервиг" } },
                ProductionDesigner = movie.ProductionDesigner,
                FilmAgeRating = new FilmAgeRatingDTO
                { Id = movie.FilmAgeRating.Id, AgeName = movie.FilmAgeRating.AgeName },
                VideoFile = new VideoFileDTO
                {
                    Id = movie.VideoFile.Id,
                    TrailerLink = movie.VideoFile.TrailerLink,
                    MovieId = movie.VideoFile.MovieId
                },
                FramesImageSource = new List<string>
                    {
                        { "StaticFiles/images/Movies/LittleWomenSrceen1.jpg" },
                        { "StaticFiles/images/Movies/LittleWomenSrceen2.jpg" },
                        { "StaticFiles/images/Movies/LittleWomenSrceen3.jpg" }
                    }
            };

            return movieDTO;
        }
    }
}
