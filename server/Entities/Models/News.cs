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
        public int NewsId { get; set; }
        public string NewsTitle { get; set; }
        public string NewsContent { get; set; }
        public int CountViews { get; set; }
        public string ImageSource { get; set; }
        public DateTime PublishTime { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public ICollection<NewsCategory> NewsCategories { get; set; }
    }
}