using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Entities.Models;

namespace WebAPI.DTO
{
    public class ReviewDTO
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int FilmId { get; set; }
        [Required]
        public string FilmImage { get; set; }
        [Required]
        public ContentType ContentType { get; set; }
        [Required]
        [MinLength(15)]
        [MaxLength(150)]
        public string ReviewTitle { get; set; }
        [Required]
        [MinLength(20)]
        [MaxLength(2000)]
        public string ReviewContent { get; set; }
        public int CountLikes { get; set; }
        public int CountDislikes { get; set; }
        public int CountComments { get; set; }
        [Required]
        public DateTime PublishTime { get; set; }
        [Required]
        [Range(0.0, 5.0)]
        public float DirectingRating { get; set; }
        [Required]
        [Range(0.0, 5.0)]
        public float PlotRating { get; set; } 
        [Required]
        [Range(0.0, 5.0)]
        public float SpectacleRating { get; set; }
        [Required]
        [Range(0.0, 5.0)]
        public float ActorsRating { get; set; }
    }
}
