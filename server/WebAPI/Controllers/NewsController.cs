using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using Entities.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {

        private readonly NewsService newsService;
        public NewsController(NewsService newsService)
        {
            this.newsService = newsService;
        }
        [HttpGet]
        [Route("News")]
        public IActionResult GetListCelebrities()
        {
            var objectList = newsService.GetAllNews();
            return Ok(objectList);
        }
    }
}