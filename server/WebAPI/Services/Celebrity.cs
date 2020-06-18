using Entities.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTO;

namespace WebAPI.Services
{
    public class Celebrity : ICelebrity
    {
        public CelebrityDTO GetCelebrity(FilmFinityDbContext dbContext)
        {
            return default;
        }

        public List<CelebrityDTO> ListCelebrities(FilmFinityDbContext dbContext)
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
                JobTitles = o.CelebrityJobTitles.Select(j => j.JobTitle).Select(j => new JobTitleDTO
                { JobTitleId = j.JobTitleId, JobName = j.JobName }).ToList()
            }).ToList();
        }
    }
}
