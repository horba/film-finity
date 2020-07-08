using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Models;

namespace Entities.Models
{
    public class MovieGenreTitles
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int GenreId { get; set; }
        public Genre GenreTitle { get; set; }
    }
}
