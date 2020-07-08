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
        SerialDTO GetSerialByUserId(int Id);
    }
}
