using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class SerialGenreTitles
    {
        public int SerialId { get; set; }
        public Serial Serial { get; set; }
        public int GenreId { get; set; }
        public Genre GenreTitle { get; set; }
    }
}
