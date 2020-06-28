using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class NewsCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<NewsCategories> NewsCategories { get; set; }
    }
}