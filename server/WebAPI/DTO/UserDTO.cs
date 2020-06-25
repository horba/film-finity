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
        //[Required(ErrorMessage = "Укажите имя пользователя")]
       //Required]
       [MinLength(5)]
        public string UserName { get; set; }
      //  [Required(ErrorMessage = "Укажите Email")]
        public string Email { get; set; }
       // [Required(ErrorMessage = "Укажите пароль")]
        public string UserPassword { get; set; }
    }
}
