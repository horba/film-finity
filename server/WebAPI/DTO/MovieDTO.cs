using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.DTO
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Rate { get; set; }
        public int ReleaseYear { get; set; }
        public string ImageSource { get; set; }

        public ICollection<ActorDTO> ActorsList { get; set; }
    }
}
