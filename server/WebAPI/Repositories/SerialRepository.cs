using Entities.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTO;

namespace WebAPI.Repositories
{
    public class SerialRepository : Repository<SerialDTO>, ISerialRepository
    {
        public SerialRepository(FilmFinityDbContext context)
            : base(context)
        { }

        public List<SerialDTO> GetAllSerials()
        {
            return FilmFinityDbContext.Serials
                .Include(m => m.Artist)
                .ToList();
        }
    }
}
