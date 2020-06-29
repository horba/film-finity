using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace Entities.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int CountViews { get; set; }
        public string PreviewImage { get; set; }
        public DateTime PublishTime { get; set; }
        public NewsAuthor Author { get; set; }
        public int AuthorId { get; set; }
        public ICollection<NewsCategories> NewsCategories { get; set; }
    }
}