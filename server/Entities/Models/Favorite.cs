using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Models
{
    public enum ContentType
    {
        Serial=0,
        Movie=1
    }
    public class Favorite
    {
        public int Id { get; set; }
        [Required]
        [Range(0, 1)]
        public ContentType ContentType { get; set; }        
        [Required]
        public int ContentId { get; set; }
        [Required]
        public DateTime AddedTime { get; set; }
    }
}
