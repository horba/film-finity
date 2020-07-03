using AutoMapper;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTO;
using WebAPI.Repositories;

namespace WebAPI.Services
{
    public class ReviewsService : IReviewsService
    {
        private readonly IReviewsRepository _reviewsRepository;
        private readonly IMoviesService _moviesService;
        private readonly ISerialsService _serialsService;
        private readonly IMapper _mapper;

        public ReviewsService(IReviewsRepository _newsRepository, IMoviesService _moviesRepository, ISerialsService _serialsRepository, IMapper _mapper)
        {
            this._reviewsRepository = _newsRepository;
            this._moviesService = _moviesRepository;
            this._serialsService = _serialsRepository;
            this._mapper = _mapper;
        }
        public IEnumerable<ReviewDTO> GetReviewsByUserId(int UserId)
        {
            var reviewsList = _mapper.Map<IEnumerable<Review>, IEnumerable<ReviewDTO>>(_reviewsRepository.GetAllReviewsByUserId(UserId).ToList());
            foreach (var item in reviewsList)
            {
                if(item.ContentType == ContentType.Movie)
                {
                    item.FilmImage = _moviesService.GetMovieById(item.FilmId).ImageSource;
                }
                else if(item.ContentType == ContentType.Serial)
                {
                    item.FilmImage = _serialsService.GetSerialById(item.FilmId).PosterImageSource;
                }
            }
            return reviewsList;
        }
    }
}
