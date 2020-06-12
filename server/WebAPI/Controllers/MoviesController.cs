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
    public class MoviesController : ControllerBase
    {
        private readonly FilmFinityDbContext dbContext;

        public MoviesController(FilmFinityDbContext filmFinityDbContext)
        {
            this.dbContext = filmFinityDbContext;
        }


        [HttpGet]        
        public IActionResult GetListMovies()
        {
            List<MovieDTO> objectList = dbContext.Movies.Select(o => new MovieDTO
            {
                Id = o.Id,
                Title = o.Title,
                Rate = o.Rate,
                ReleaseYear = o.ReleaseYear,
                ImageSource = o.ImageSource,
                ActorsList = o.ActorsList.Select(j => j.Actor).Select(j => new ActorDTO
                { FullName = j.FullName }).ToList()
            }).ToList();

            return Ok(objectList);
        }
    }
}
