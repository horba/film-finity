using Entities.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTO;

namespace WebAPI.Services
{
    public interface ICelebrityService
    {
        List<CelebrityDTO> GetCelebrities();
        CelebrityDTO GetCelebrity(int CelebrityId);
    }
    public class CelebrityService : ICelebrityService
    {
        private readonly FilmFinityDbContext dbContext;
        private protected Random rand = new Random();
        public CelebrityService(FilmFinityDbContext filmFinityDbContext)
        {
            this.dbContext = filmFinityDbContext;
        }

        public List<CelebrityDTO> GetCelebrities()
        {
            return dbContext.Celebrities.Select(o => new CelebrityDTO
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
                    { "actoringRate", Math.Round(rand.NextDouble() * 5, 1)},
                    { "directionRate", Math.Round(rand.NextDouble() * 5, 1)},
                    { "scenaristRate", Math.Round(rand.NextDouble() * 5, 1)},
                    { "productionRate", Math.Round(rand.NextDouble() * 5, 1)},
                    { "operationRate", Math.Round(rand.NextDouble() * 5, 1)},
                    { "compositionRate", Math.Round(rand.NextDouble() * 5, 1)},
                },
                NetworkingSites = new NetworkingSitesDTO
                {
                    Facebook = o.CelebrityNetworkingSites.Facebook,
                    Instagram = o.CelebrityNetworkingSites.Instagram,
                    Twitter = o.CelebrityNetworkingSites.Twitter,
                },
                JobTitles = o.CelebrityJobTitles.Select(j => j.JobTitle).Select(j => new JobTitleDTO
                { JobTitleId = j.JobTitleId, JobName = j.JobName }).ToList()
            }).ToList();
        }

        public CelebrityDTO GetCelebrity(int CelebrityId)
        {
            return dbContext.Celebrities.Select(o => new CelebrityDTO
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
        }
    }
}
