using Entities.DataAccess;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTO;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public class SerialRepository : Repository<SerialDTO>, ISerialRepository
    {
        public SerialRepository(FilmFinityDbContext context)
            : base(context)
        { }

        public List<Serial> GetAllSerials()
        {
            return _dbContext.Serials
                .Include(n => n.SerialCelebrity)
                    .ThenInclude(n => n.Celebrity)
                    .ThenInclude(n => n.CelebrityJobTitles)
                    .ThenInclude(n => n.JobTitle)
                .Include(n => n.SerialGenreTitles)
                    .ThenInclude(n => n.GenreTitle)
                    .ToList();
        }
        public Serial GetSerialById(int id)
        {
            return _dbContext.Serials
                .Include(n => n.SerialCelebrity)
                    .ThenInclude(n => n.Celebrity)
                    .ThenInclude(n => n.CelebrityJobTitles)
                    .ThenInclude(n => n.JobTitle)
                .Include(n => n.SerialGenreTitles)
                    .ThenInclude(n => n.GenreTitle)
                    .Where(x => x.Id == id)
                    .First();
        }
    }
}
