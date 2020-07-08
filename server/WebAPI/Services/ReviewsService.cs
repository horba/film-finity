using AutoMapper;
using Entities.Models;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.DTO;
using WebAPI.HelpModels;
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

        public int? getReviewPage(int UserId, int PageNumber, int PageSize, ReviewSortState sortState, string titleName)
        {
            if(titleName == null) return null;
            var reviewsList = _mapper.Map<IEnumerable<Review>, IEnumerable<ReviewDTO>>(_reviewsRepository.GetAllReviews(UserId));
            reviewsList = sortQuery(reviewsList, sortState);
            var foundElement = reviewsList.FirstOrDefault(s => s.ReviewTitle.Contains(titleName));
            if (foundElement == null) return null;
            int index = reviewsList.IndexOf(foundElement)+1;
            if (index <= PageSize) return 1;
            var remaining = ((double)index / (double)PageSize);
            return (int)Math.Round(remaining, 0, MidpointRounding.AwayFromZero);
        }

        public IPagedResponse<ReviewDTO> GetReviews(int UserId, int PageNumber, int PageSize, ReviewSortState sortState)
        {
            var reviewsList = _mapper.Map<IEnumerable<Review>, IEnumerable<ReviewDTO>>(_reviewsRepository.GetAllReviews(UserId));
            foreach (var item in reviewsList)
            {
                if(item.ContentType == ContentType.Movie)
                {
                    item.FilmImage = _moviesService.GetMovieByUserId(item.FilmId).ImageSource;
                }
                else if(item.ContentType == ContentType.Serial)
                {
                    item.FilmImage = _serialsService.GetSerialByUserId(item.FilmId).PosterImageSource;
                }
            }
            var reviewsListPaged = paginateQuery(reviewsList, sortState, PageNumber, PageSize);
            return new IPagedResponse<ReviewDTO>(reviewsListPaged)
            {
                PageSize = PageSize,
                TotalCount = reviewsList.Count(),
                PageNumber = PageNumber
            };
        }

        float getFilmRating (ReviewDTO model)
        {
            return (model.DirectingRating + model.PlotRating + model.SpectacleRating + model.ActorsRating) / 4;
        }

        IEnumerable<ReviewDTO> paginateQuery (IEnumerable<ReviewDTO> reviewsList, ReviewSortState sortState, int PageNumber, int PageSize)
        {
            reviewsList = sortQuery(reviewsList, sortState);
            var reviewsListPaged = reviewsList.Skip((PageNumber - 1) * PageSize)
            .Take(PageSize);
            if (reviewsListPaged.Count() == 0)
            {
                PageNumber = 1;
                reviewsListPaged = reviewsList.Skip((PageNumber - 1) * PageSize)
                .Take(PageSize);
            }
            return reviewsListPaged;
        }

        IEnumerable<ReviewDTO> sortQuery(IEnumerable<ReviewDTO> reviewsList, ReviewSortState sortState)
        {
            return reviewsList = sortState switch
            {
                ReviewSortState.NameDesc => reviewsList.OrderByDescending(s => s.ReviewTitle),
                ReviewSortState.RatingAsc => reviewsList.OrderBy(s => getFilmRating(s)),
                ReviewSortState.RatingDesc => reviewsList.OrderByDescending(s => getFilmRating(s)),
                ReviewSortState.YearAsc => reviewsList.OrderBy(s => s.PublishTime),
                ReviewSortState.YearDesc => reviewsList.OrderByDescending(s => s.PublishTime),
                _ => reviewsList.OrderBy(s => s.ReviewTitle),
            };
        }
    }
}
