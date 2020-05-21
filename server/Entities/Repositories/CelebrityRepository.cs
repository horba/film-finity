using Entities.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using WebAPI.Models;

namespace Entities.Repositories
{

    public class CelebrityRepository
    {
        private readonly FilmFinityDbContext dbContext;

        public CelebrityRepository(FilmFinityDbContext repositoryContext)
        {
            this.dbContext = repositoryContext;
        }

        public void GetAllCelebrities()
        {
            var objectList = dbContext.Celebrities.Select(o => new
            {
                o.CelebrityId,
                o.FirstName,
                o.LastName,
                o.CountViews,
                JobTitle = o.CelebrityJobTitles.Select(ot => new { ot.JobTitle.JobTitleId /*, ot.JobTitle.Job */}).ToList()
            }).ToList();

            //return objectList;

        }
    }
}
