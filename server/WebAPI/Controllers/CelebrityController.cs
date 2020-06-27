using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.Services;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class CelebrityController : ControllerBase
    {
        private readonly ICelebrityService celebrityService;

        public CelebrityController(ICelebrityService celebrityService)
        {
            this.celebrityService = celebrityService;
        }
        

        [HttpGet]
        [Route("Celebrity")]
        public IActionResult GetListCelebrities()
        {
            return Ok(celebrityService.GetCelebrities());
        }

        [HttpGet]
        [Route("{CelebrityId}")]
        public IActionResult GetCelebrity(int CelebrityId)
        {          
            return Ok(celebrityService.GetCelebrity(CelebrityId));
        }
    }
}