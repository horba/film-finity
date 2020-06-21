using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Repositories;
using WebAPI.DTO;
using Entities.Models;
using AutoMapper;
using WebAPI.Validation;
using FluentValidation;

namespace WebAPI.Services
{
    public class NewsService
    {
        private readonly NewsRepository _newsRepository;
        private readonly IMapper _mapper;

        public NewsService(NewsRepository _newsRepository, IMapper _mapper)
        {
            this._newsRepository = _newsRepository;
            this._mapper = _mapper;
        }
        public IEnumerable<NewsDTO> GetAllNews()
        {
            var news = _newsRepository.GetAllNews();
            var validator = new ValidateNews();
            foreach (var newsElement in news)
            {
                try 
                {
                    validator.ValidateAndThrow(newsElement);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    news = news.Where(el => el != newsElement);
                }
            }
            return _mapper.Map<IEnumerable<NewsDTO>>(news.ToList());
        }
    }
}
