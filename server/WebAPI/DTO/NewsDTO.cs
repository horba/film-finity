using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;

namespace WebAPI.DTO
{
    public class NewsDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int CountViews { get; set; }
        public string PreviewImage { get; set; }
        public DateTime PublishTime { get; set; } 
        public NewsAuthorDTO Author { get; set; }
        public List<NewsCategoryDTO> Categories { get; set; }
    }
}
