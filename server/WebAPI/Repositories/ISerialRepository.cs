using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTO;

namespace WebAPI.Repositories
{
    public interface ISerialRepository : IRepository<SerialDTO>
    {
        List<Serial> GetAllSerials();
        IQueryable<Serial> GetSerialByUserId(int Id);
    }
}
