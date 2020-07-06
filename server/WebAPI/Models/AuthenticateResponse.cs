using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTO;

namespace WebAPI.Models
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }


        public AuthenticateResponse(UserDTO user, string token)
        {
            Id = user.Id;
            Email = user.Email;
            Username = user.UserName;
            Token = token;
        }
    }
}
