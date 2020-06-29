using Entities.DataAccess;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTO;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public class UserRepository : Repository<UserDTO>, IUserRepository
    {
        public UserRepository(FilmFinityDbContext context)
            : base(context)
        { }

        public IEnumerable<User> GetAllUsers()
        {
            return _dbContext.Users;
        }

        public bool isEmailInUse(string email)
        {
            User user = _dbContext.Users.FirstOrDefault(x => x.Email == email);
            if (user == null)
            {
                return false;
            }
            return true;
        }

        public void Create(User value)
        {
            User user = _dbContext.Users.FirstOrDefault(x => x.Email == value.Email);
            if (user == null)
            {
                _dbContext.Users.Add(value);
                _dbContext.SaveChanges();
            }
        }
    }
}
