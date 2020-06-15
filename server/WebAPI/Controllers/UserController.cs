using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace WebAPI.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly FilmFinityDbContext dbContext;
        
        public UserController(FilmFinityDbContext filmFinityDbContext)
        {
            this.dbContext = filmFinityDbContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {
            return await dbContext.Users.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<User>> Post(User value)
        {
            User user = await dbContext.Users.FirstOrDefaultAsync(x => x.Email == value.Email);
            if (user == null)
            {
                dbContext.Users.Add(value);
                await dbContext.SaveChangesAsync();
                return Ok(user);
            }
            return BadRequest();
        }        
    }
}