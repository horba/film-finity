using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.DTO
{
    public class FavoriteDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public int Year { get; set; }
        public string PosterImageSource { get; set; }
        public List<MovieActorDTO> Celebrities { get; set; }
    }
    //public enum ContentType
    //{
    //    Serial,
    //    Movie
    //}
    //public class FavoriteDTO
    //{
    //    public int Id { get; set; }
    //    [Required]
    //    [Range(0, 1)]
    //    public ContentType contentType { get; set; }
    //    [Required]
    //    public int ContentId { get; set; }
    //    [Required]
    //    public DateTime AddedTime { get; set; }
    //}
}
