using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class JobTitle
    {
        public int JobTitleId { get; set; }
        public string JobName { get; set; }

        public ICollection<CelebrityJobTitles> CelebrityJobTitles { get; set; }
    }
}
