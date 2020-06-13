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
    
    [ApiController]
    [Route("api/[controller]")]
    public class CelebrityController : ControllerBase
    {
        private readonly FilmFinityDbContext dbContext;
        
        public CelebrityController(FilmFinityDbContext filmFinityDbContext)
        {
            this.dbContext = filmFinityDbContext;
        }
        

        [HttpGet]
        [Route("Celebrities")]
        public IActionResult GetListCelebrities()
        {
            List<CelebrityDTO> objectList = dbContext.Celebrities.Select(o => new CelebrityDTO
            {
                CelebrityId = o.CelebrityId,
                FirstName = o.FirstName,
                LastName = o.LastName,
                CountViews = o.CountViews,
                ImageSource = o.ImageSource,
                JobTitles = o.CelebrityJobTitles.Select(j => j.JobTitle).Select( j => new JobTitleDTO 
                { JobTitleId = j.JobTitleId, JobName = j.JobName }).ToList()
            }).ToList();

            return Ok(objectList);
        }
    }
}