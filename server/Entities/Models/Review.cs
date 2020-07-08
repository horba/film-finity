using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Entities.Models
{
    public class Review
    {
        public int Id { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int FilmId { get; set; }
        [Required]
        public ReviewContentType ContentType { get; set; }
        [Required]
        [MinLength(15)]
        [MaxLength(150)]
        public string ReviewTitle { get; set; }
        [Required]
        [MinLength(20)]
        [MaxLength(2000)]
        public string ReviewContent { get; set; }
        [Required]
        public DateTime PublishTime { get; set; }
        [Required]
        [Range(0.0, 5.0)]
        public float DirectingRating { get; set; } = new Random().Next(0, 6);
        [Required]
        [Range(0.0, 5.0)]
        public float PlotRating { get; set; } = new Random().Next(0, 6);
        [Required]
        [Range(0.0, 5.0)]
        public float SpectacleRating { get; set; } = new Random().Next(0, 6);
        [Required]
        [Range(0.0,5.0)]
        public float ActorsRating { get; set; } = new Random().Next(0, 6);
    }
    public enum ReviewContentType
    {
        Serial,
        Movie
    }

}
