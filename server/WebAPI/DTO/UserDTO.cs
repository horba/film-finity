using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите имя пользователя")]
        public string UserName { get; set; }
        
        [EmailAddress(ErrorMessage = "Введите email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Введите пароль")]
        public string UserPassword { get; set; }
    }
}
