using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;

namespace WebAPI.DTO
{
    public class NewsDTO
    {
        public int NewsId { get; set; }
        public string NewsTitle { get; set; }
        public string NewsContent { get; set; }
        public int CountViews { get; set; }
        public string ImageSource { get; set; }
        public DateTime PublishTime { get; set; } 
        public AuthorDTO Author { get; set; }
        public ICollection<CategoryDTO> CelebrityJobTitles { get; set; }
    }
}
