using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SerialController : ControllerBase
    {
        private readonly FilmFinityDbContext dbContext;
        public SerialController(FilmFinityDbContext filmFinityDbContext)
        {
            this.dbContext = filmFinityDbContext;
        }

        [HttpGet]
        public IActionResult GetListCelebrities()
        {
            List<SerialDTO> objectList = dbContext.Serials.Select(o => new SerialDTO
            {
                SerialId = o.SerialId,
                Name = o.Name,
                Rating = o.Rating,
                Year = o.Year,
                ImageSource = o.ImageSource,
                GenreTitles = o.SerialGenreTitles.Select(j => j.GenreTitle).Select(j => new GenreDTO
                { GenreId = j.GenreId, GenreName = j.GenreName }).ToList(),
                Celebrities = o.SerialCelebrity.Select(j => j.Celebrity).Select(j => new CelebrityDTO
                { 
                    CelebrityId = j.CelebrityId,
                    FirstName = j.FirstName,
                    CountViews = j.CountViews,
                    LastName = j.LastName,
                    ImageSource = j.ImageSource
                }).ToList()
            }).ToList();
            return Ok(objectList);
        }
    }
}