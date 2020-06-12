using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class News
    {
        public int NewsId { get; set; }
        public string NewsTitle { get; set; }
        public string NewsContent { get; set; }
        public string CountComments { get; set; }
        public string CountViews { get; set; }
        public string ImageSource { get; set; }
        public DateTime PublishTime { get; set; }
        public ICollection<NewsAuthor> NewsAuthors { get; set; }
        public ICollection<NewsCategory> NewsCategories { get; set; }
    }
}