using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTO;

namespace WebAPI.Repositories
{
    public interface ISerialRepository : IRepository<SerialDTO>
    {
        List<SerialDTO> GetAllSerials();
    }
}
