using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace WebAPI.DTO
{
    public class ReviewDTO
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(100)]
        public string ReviewTitle { get; set; }
        [Required]
        [MinLength(20)]
        [MaxLength(2000)]
        public string ReviewContent { get; set; }
        [Required]
        public int CountLikes { get; set; }
        [Required]
        public int CountDislikes { get; set; }
        [Required]
        public int CountComments { get; set; }
        [Required]
        public DateTime PublishTime { get; set; }
        [Required]
        [MaxLength(5)]
        public float DirectingRating { get; set; }
        [Required]
        [MaxLength(5)]
        public float PlotRating { get; set; }
        [Required]
        [MaxLength(5)]
        public float SpectacleRating { get; set; }
        [Required]
        [MaxLength(5)]
        public float ActorsRating { get; set; }
    }
}
