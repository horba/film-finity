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
        private readonly ISerialsService serialsService;
        public SerialController(ISerialsService serialsService)
        {
            this.serialsService = serialsService;
        }

        [HttpGet]
        public IActionResult GetListCelebrities()
        {
            List<SerialDTO> objectList = serialsService.GetSerials();
            return Ok(objectList);
        }
    }
}