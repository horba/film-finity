using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Celebrity
    {
        public int CelebrityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CountViews { get; set; }
        public string ImageSource { get; set; }

        public ICollection<CelebrityJobTitles> CelebrityJobTitles { get; set; }
        
    }
}
