using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Repositories;
using WebAPI.DTO;
using Entities.Models;
using AutoMapper;
using FluentValidation;

namespace WebAPI.Services
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _newsRepository;
        private readonly IMapper _mapper;

        public NewsService(INewsRepository _newsRepository, IMapper _mapper)
        {
            this._newsRepository = _newsRepository;
            this._mapper = _mapper;
        }
        public IEnumerable<NewsDTO> GetAllNews()
        {
            var news = _newsRepository.GetAllNews();
            return _mapper.Map<IEnumerable<NewsDTO>>(news.ToList());
        }
    }
}
