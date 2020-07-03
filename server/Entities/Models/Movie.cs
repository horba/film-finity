using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }        
        public int Rate { get; set; }
        public int ReleaseYear { get; set; }
        public string ImageSource { get; set; }

        public ICollection<ActorsList> ActorsList { get; set; }

    }
}
