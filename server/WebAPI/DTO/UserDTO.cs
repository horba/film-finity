using Newtonsoft.Json;
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
        [Required]
        public string UserName { get; set; }        
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [JsonIgnore]
        public string UserPassword { get; set; }
    }
}
