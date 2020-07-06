using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Models;

namespace Entities.Models
{
    public class FilmAgeRating
    {
        public int Id { get; set; }
        public string Age { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
