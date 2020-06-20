using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.DTO
{
    public class SerialDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public int Year { get; set; }
        public string PosterImageSource { get; set; }
        public List<GenreDTO> GenreTitles { get; set; }
        public List<CelebrityDTO> Celebrities { get; set; }
    }
}
