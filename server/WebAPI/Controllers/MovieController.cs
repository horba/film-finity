using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly FilmFinityDbContext dbContext;

        public MovieController(FilmFinityDbContext filmFinityDbContext)
        {
            this.dbContext = filmFinityDbContext;
        }


        [HttpGet]
        [Route("Movies")]
        public IActionResult GetListMovies()
        {
            List<MovieDTO> objectList = dbContext.Movies.Select(o => new MovieDTO
            {
                MovieId = o.MovieId,
                MovieTitle = o.MovieTitle,
                CountStars = o.CountStars,
                ReleaseYear = o.ReleaseYear,
                ImageSource = o.ImageSource,
                ActorsList = o.ActorsList.Select(j => j.Actor).Select(j => new ActorDTO
                { ActorName = j.ActorName }).ToList()
            }).ToList();

            return Ok(objectList);
        }
    }
}
