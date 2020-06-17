using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Repositories;
using WebAPI.DTO;
using Entities.Models;
using AutoMapper;

namespace WebAPI.Services
{
    public class NewsService
    {
        private readonly NewsRepository newsRepo;

        public NewsService(NewsRepository newsRepo)
        {
            this.newsRepo = newsRepo;
        }
        public List<NewsDTO> GetAllNews()
        {
            var news = newsRepo.GetAllNews().ToList();
            return news;
        }
    }
}
