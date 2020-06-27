using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Models;
using WebAPI.Repositories;
using AutoMapper;
using WebAPI.DTO;
using System.Linq;

namespace WebAPI.Services
{
    public class UserService
    {
        private readonly UserRepository userRepository;
        private readonly IMapper mapper;

        public UserService(UserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public IEnumerable<UserDTO> GetUsers()
        {
            var users = userRepository.GetAll();
            return mapper.Map<IEnumerable<UserDTO>>(users.ToList());
        }
        public bool isEmailInUse(string email)
        {            
            return userRepository.isEmailInUse(email);
        }
        public void CreateUser(UserDTO userDTO)
        {
            User user = mapper.Map<UserDTO, User>(userDTO);
            userRepository.Create(user);
        }
    }
}
