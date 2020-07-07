using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SerialController : ControllerBase
    {
        private readonly ISerialsService _serialsService;
        public SerialController(ISerialsService serialsService)
        {
            this._serialsService = serialsService;
        }

        [HttpGet]
        public IActionResult GetListCelebrities()
        {
            List<SerialDTO> objectList = _serialsService.GetSerials();
            return Ok(objectList);
        }

        [HttpGet("{id}")]
        public IActionResult GetSerial(int id)
        {
            SerialDTO objectList = _serialsService.GetSerialById(id);
            return Ok(objectList);
        }

    }
}