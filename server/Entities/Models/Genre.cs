using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public ICollection<SerialGenreTitles> SerialGenreTitles { get; set; }
    }
}
