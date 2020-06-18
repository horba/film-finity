using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class NewsAuthor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<News> News { get; set; }
    }
}
