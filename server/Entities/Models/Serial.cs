using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Serial
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public int Year { get; set; }
        public string PosterImageSource { get; set; }
        public ICollection<SerialGenreTitles> SerialGenreTitles { get; set; }
        public ICollection<SerialCelebrity> SerialCelebrity { get; set; }
    }
}
