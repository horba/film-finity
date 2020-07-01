using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MoviesService moviesService;
        public MoviesController(MoviesService moviesService)
        {
            this.moviesService = moviesService;
        }

        [HttpGet]        
        public IActionResult GetListMovies()
        {
            var objectList = moviesService.GetAllMovies();
            return Ok(objectList);
        }
    }
}
