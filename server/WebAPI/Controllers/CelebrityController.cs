using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.DataAccess;
using Entities.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class CelebrityController : ControllerBase
    {
        private readonly CelebrityRepository celebrityRepository;
        private readonly FilmFinityDbContext dbContext;
        
        public CelebrityController(CelebrityRepository celebrityRepository, FilmFinityDbContext filmFinityDbContext)
        {
            this.celebrityRepository = celebrityRepository;
            this.dbContext = filmFinityDbContext;
        }
        

        [HttpGet]
        //[Route("GetAllCelebrities")]
        public IActionResult GetListCelebrities()
        {
            var objectList = dbContext.Celebrities.Select(o => new
            {
                o.CelebrityId,
                o.FirstName,
                o.LastName,
                o.CountViews,

                JobTitle = o.CelebrityJobTitles.Select(ot => new { ot.JobTitle.JobTitleId, ot.JobTitle.Job}).ToList()
            }).ToList();

            return Ok(objectList);
        }
    }
}