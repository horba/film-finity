using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public ICollection<News> News { get; set; }
    }
}
