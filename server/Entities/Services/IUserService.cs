using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Models;

namespace Entities.Services
{
    public interface IUserService
    {
        bool IsUserExist(User user);
        void CreateUser(User user);
    }
}
