using AutoMapper;
using Entities.DataAccess;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTO;
using WebAPI.Repositories;

namespace WebAPI.Services
{
    public class SerialsService : ISerialsService
    {
        private readonly ISerialRepository _serialRepository;
        private readonly IMapper _mapper;

        public SerialsService(ISerialRepository _serialRepository, IMapper _mapper)
        {
            this._serialRepository = _serialRepository;
            this._mapper = _mapper;
        }
        public List<SerialDTO> GetSerials()
        {
            var serials = _serialRepository.GetAllSerials();
            return _mapper.Map<List<SerialDTO>>(serials.ToList());
        }
        public SerialDTO GetSerialByUserId(int Id)
        {
            var serial = _serialRepository.GetSerialByUserId(Id).Single();
            return _mapper.Map<Serial, SerialDTO>(serial);
        }
    }
}
