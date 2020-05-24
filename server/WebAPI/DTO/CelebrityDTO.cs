using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.DTO
{
    public class CelebrityDTO
    {
        public int CelebrityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CountViews { get; set; }
        public string ImageSource { get; set; }

        public List<JobTitleDTO> JobTitles { get; set; }
    }
}
