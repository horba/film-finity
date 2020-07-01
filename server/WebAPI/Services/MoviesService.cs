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
    public class MoviesService
    {
        private readonly IMapper _mapper;
        private readonly MoviesRepository _moviesRepository;

        public MoviesService(MoviesRepository moviesRepository)
        {
            var configMapper = new MapperConfiguration(cfg =>                
                cfg.CreateMap<Movie, MovieDTO>()
                    .ForMember(dto => dto.ActorsList, opt => opt.MapFrom(
                        list => list.ActorsList.ToList().Select
                        (item => new MovieActorDTO { FullName = item.Actor.FullName, Id = item.ActorId})))
                );
            _mapper = new Mapper(configMapper);
            _moviesRepository = moviesRepository;
        }
        public IEnumerable<MovieDTO> GetAllMovies()
        {
            var movies = _moviesRepository.GetAllMovies();
            return _mapper.Map<IEnumerable<Movie>, IEnumerable < MovieDTO >> (movies.ToList());
        }
    }
}
