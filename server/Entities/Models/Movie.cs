using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }        
        public int CountStars { get; set; }
        public int ReleaseYear { get; set; }
        public string ImageSource { get; set; }

        public ICollection<ActorsList> ActorsList { get; set; }

    }
}
