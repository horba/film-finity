using Entities.DataAccess;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public class UserRepository
    {
        private readonly FilmFinityDbContext dbContext;
        public UserRepository(FilmFinityDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<User> GetAll()
        {
            return dbContext.Users;
        }

        public void Create(User value)
        {
            User user = dbContext.Users.FirstOrDefault(x => x.Email == value.Email);
            if (user == null)
            {
                dbContext.Users.Add(value);
                dbContext.SaveChanges();
            }
        }
    }
}
