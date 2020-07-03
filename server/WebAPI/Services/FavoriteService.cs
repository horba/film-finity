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
        private readonly IFavoriteRepository favoriteRepository;
        private readonly IMapper mapper;

        public FavoriteService(IFavoriteRepository favoriteRepository, ISerialRepository _serialRepository, IMapper mapper)
        {
            this.favoriteRepository = favoriteRepository;
            this._serialRepository = _serialRepository;
            this.mapper = mapper;
        }
        public List<FavoriteDTO> GetFavorites()
        {
            var favorites = favoriteRepository.GetAllFavorites();         
            var favoriteSerial = favorites.Where(s => s.ContentType == ContentType.Serial).Select(i => (_serialRepository.GetSerialById(i.ContentId)));
            //var favoriteMovie = favorites.Where(s => s.ContentType == ContentType.Movie).Select(i => (_movieRepository.GetMoviebyId(i.ContentId)));

 
            return mapper.Map<List<FavoriteDTO>>(favoriteSerial);

        }
        //public List<FavoriteDTO> GetFavorites()
        //{
        //    var favorites = favoriteRepository.GetAllFavorites();
        //    List<FavoriteDTO> myFavorites = new List<FavoriteDTO>();

        //    foreach (var favorite in favorites)
        //    {
        //        if (favorite.ContentType == ContentType.Serial)
        //        {
        //            myFavorites.Add(mapper.Map<FavoriteDTO>(_serialRepository.GetSerialbyId(favorite.ContentId)));
        //        }

        //    }                //else
        //                     //{
        //                     //    myFavorites.Add(mapper.Map<FavoriteDTO>(_movesRepository.GetSerialId(favorite.ContentId)));
        //                     //}

        //    //  List<FavoriteDTO> myFavorites = favorites.Where(f => f.ContentType == ContentType.Serial);

        //    return myFavorites;
        //}
    }
}
