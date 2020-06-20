using Entities.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTO;

namespace WebAPI.Services
{
    public interface ISerialsService
    {
        List<SerialDTO> GetSerials();
    }

    public class SerialsService : ISerialsService
    {
        private readonly FilmFinityDbContext dbContext;
        public SerialsService(FilmFinityDbContext filmFinityDbContext)
        {
            this.dbContext = filmFinityDbContext;
        }
        public List<SerialDTO> GetSerials()
        {
            List<SerialDTO> objectList = dbContext.Serials.Select(o => new SerialDTO
            {
                Id = o.Id,
                Name = o.Name,
                Rating = o.Rating,
                Year = o.Year,
                PosterImageSource = o.PosterImageSource,
                GenreTitles = o.SerialGenreTitles.Select(j => j.GenreTitle).Select(j => new GenreDTO
                { Id = j.Id, Name = j.Name }).ToList(),
                Celebrities = o.SerialCelebrity.Select(j => j.Celebrity).Select(j => new CelebrityDTO
                {
                    CelebrityId = j.CelebrityId,
                    FirstName = j.FirstName,
                    CountViews = j.CountViews,
                    LastName = j.LastName,
                    ImageSource = j.ImageSource,
                    JobTitles = j.CelebrityJobTitles.Select(g => g.JobTitle).Select(g => new JobTitleDTO
                    { JobTitleId = g.JobTitleId, JobName = g.JobName }).ToList()
                }).ToList()
            }).ToList();
            return objectList;
        }
    }
}
