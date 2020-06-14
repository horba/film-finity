using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.Services;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class CelebrityController : ControllerBase
    {
        private readonly FilmFinityDbContext dbContext;
        private ICelebrity celebrityService;

        public CelebrityController(FilmFinityDbContext filmFinityDbContext)
        {
            this.dbContext = filmFinityDbContext;
            //this.celebrityService = celebrityService;
        }
        

        [HttpGet]
        [Route("Celebrity")]
        public IActionResult GetListCelebrities()
        {
            Random rand = new Random();

            List<CelebrityDTO> objectList = dbContext.Celebrities.Select(o => new CelebrityDTO
            {
                CelebrityId = o.CelebrityId,
                FirstName = o.FirstName,
                LastName = o.LastName,
                CountViews = o.CountViews,
                ImageSource = o.ImageSource,
                Birthday = o.Birthday,
                PlaceOfBirthday = o.PlaceOfBirthday,
                StarSing = o.StarSing,
                Height = o.Height,
                FamilyStatus = o.FamilyStatus,
                Achievement = o.Achievement,
                Biography = 
                o.CelebrityBiography.ShortDescription + 
                o.CelebrityBiography.ChildhoodAndYouth + 
                o.CelebrityBiography.PersonalLife +
                o.CelebrityBiography.CareerInCinema +
                o.CelebrityBiography.AdditionalInfo,
                Rates = new Dictionary<string, double>
                {
                    { "actoringRate", Math.Round(rand.NextDouble() * 5, 2)},
                    { "directionRate", Math.Round(rand.NextDouble() * 5, 2)},
                    { "scenaristRate", Math.Round(rand.NextDouble() * 5, 2)},
                    { "productionRate", Math.Round(rand.NextDouble() * 5, 2)},
                    { "operationRate", Math.Round(rand.NextDouble() * 5, 2)},
                    { "compositionRate", Math.Round(rand.NextDouble() * 5, 2)},
                },
                NetworkingSites = new NetworkingSitesDTO { 
                    Facebook = o.CelebrityNetworkingSites.Facebook,
                    Instagram = o.CelebrityNetworkingSites.Instagram,
                    Twitter = o.CelebrityNetworkingSites.Twitter,
                },
                JobTitles = o.CelebrityJobTitles.Select(j => j.JobTitle).Select(j => new JobTitleDTO
                { JobTitleId = j.JobTitleId, JobName = j.JobName }).ToList()
            }).ToList();

            return Ok(objectList);
        }

        [HttpGet]
        [Route("Celebrity/{CelebrityId}")]
        public IActionResult GetCelebrity(int CelebrityId)
        {
            Random rand = new Random();

            CelebrityDTO Celebrity = dbContext.Celebrities.Select(o => new CelebrityDTO
            {
                CelebrityId = o.CelebrityId,
                FirstName = o.FirstName,
                LastName = o.LastName,
                CountViews = o.CountViews,
                ImageSource = o.ImageSource,
                Birthday = o.Birthday,
                PlaceOfBirthday = o.PlaceOfBirthday,
                StarSing = o.StarSing,
                Height = o.Height,
                FamilyStatus = o.FamilyStatus,
                Achievement = o.Achievement,
                Biography =
                o.CelebrityBiography.ShortDescription +
                o.CelebrityBiography.ChildhoodAndYouth +
                o.CelebrityBiography.PersonalLife +
                o.CelebrityBiography.CareerInCinema +
                o.CelebrityBiography.AdditionalInfo,
                Rates = new Dictionary<string, double>
                {
                    { "actoringRate", Math.Round(rand.NextDouble() * 5, 2)},
                    { "directionRate", Math.Round(rand.NextDouble() * 5, 2)},
                    { "scenaristRate", Math.Round(rand.NextDouble() * 5, 2)},
                    { "productionRate", Math.Round(rand.NextDouble() * 5, 2)},
                    { "operationRate", Math.Round(rand.NextDouble() * 5, 2)},
                    { "compositionRate", Math.Round(rand.NextDouble() * 5, 2)},
                },
                NetworkingSites = new NetworkingSitesDTO
                {
                    Facebook = o.CelebrityNetworkingSites.Facebook,
                    Instagram = o.CelebrityNetworkingSites.Instagram,
                    Twitter = o.CelebrityNetworkingSites.Twitter,
                },
                JobTitles = o.CelebrityJobTitles.Select(j => j.JobTitle).Select(j => new JobTitleDTO
                { JobTitleId = j.JobTitleId, JobName = j.JobName }).ToList()
            }).Where(j => j.CelebrityId == CelebrityId).FirstOrDefault();

            return Ok(Celebrity);
        }
    }
}