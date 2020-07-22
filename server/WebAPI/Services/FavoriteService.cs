using AutoMapper;
using Entities.DataAccess;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTO;
using WebAPI.Repositories;

namespace WebAPI.Services
{
    public class FavoriteService : IFavoriteService
    {
        private readonly ISerialRepository _serialRepository;
        private readonly IMoviesRepository _movieRepository;
        private readonly IFavoriteRepository favoriteRepository;
        private readonly IMapper mapper;

        public FavoriteService(IFavoriteRepository favoriteRepository, ISerialRepository _serialRepository, IMoviesRepository _movieRepository, IMapper mapper)
        {
            this.favoriteRepository = favoriteRepository;
            this._serialRepository = _serialRepository;
            this._movieRepository = _movieRepository;
            this.mapper = mapper;
        }
        public WebAPI.DTO.IPagedResponse<FavoriteDTO> GetFavorites(int page, SortState sortOrder)
        {
            int pageSize = 8;
            var favorites = favoriteRepository.GetAllFavorites();
            var count = favorites.Count();
            var pageNumber = (int)Math.Ceiling(count / (double)pageSize);
            var favoriteSerial = mapper.Map<IEnumerable<FavoriteDTO>>(favorites.Where(s => s.ContentType == ContentType.Serial).Select(i => (_serialRepository.GetSerialById(i.ContentId))));
            var favoriteMovie = mapper.Map<IEnumerable<FavoriteDTO>>(favorites.Where(s => s.ContentType == ContentType.Movie).Select(i => (_movieRepository.GetMovieById(i.ContentId))));
            IEnumerable<FavoriteDTO> union = favoriteSerial.Union(favoriteMovie);
            union = sortOrder switch
            {
                SortState.NameDesc => union.OrderByDescending(s => s.Name),
                SortState.RatingAsc => union.OrderBy(s => s.Rating),
                SortState.RatingDesc => union.OrderByDescending(s => s.Rating),
                SortState.YearAsc => union.OrderBy(s => s.Year),
                SortState.YearDesc => union.OrderByDescending(s => s.Year),
                _ => union.OrderBy(s => s.Name),
            };
            var items = union.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            WebAPI.DTO.IPagedResponse<FavoriteDTO> pagedResponse = new WebAPI.DTO.IPagedResponse<FavoriteDTO>
            {
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalCount = count,
                Data = items
            };
            return pagedResponse;

        }
    }
}
