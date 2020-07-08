using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<SerialGenreTitles> SerialGenreTitles { get; set; }
        public ICollection<MovieGenreTitles> MovieGenres { get; set; }
    }
}
