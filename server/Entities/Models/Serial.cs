using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    class Serial
    {
        public int SerialId { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public int Year { get; set; }
        public string ImageSource { get; set; }
        public ICollection<SerialGenreTitles> SerialGenreTitles { get; set; }
    }
}
