using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.DataAccess;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.Services;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService userService;
        public UserController(UserService userService)
        {
            this.userService = userService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<UserDTO>> Get()
        {

            IEnumerable<UserDTO> objectList = userService.GetUsers();
            return Ok(objectList);
        }
        [HttpPost]
        //public void Post(UserDTO value)
        //{
        //    // userService.CreateUser(value);
        //    // return Ok(ModelState);
        //}

        public ActionResult<User> Post(UserDTO user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(!ModelState.IsValid);
        }
    }
}