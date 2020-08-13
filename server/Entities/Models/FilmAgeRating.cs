using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Models;

namespace Entities.Models
{
    public class FilmAgeRating
    {
        public int Id { get; set; }
        public string AgeName { get; set; }
        public ICollection<Movie> Movie { get; set; }
    }
}
