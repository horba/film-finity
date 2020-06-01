using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Models;

namespace Entities.Models
{
    public class CelebrityJobTitles
    {
        public int CelebrityId { get; set; }
        public Celebrity Celebrity { get; set; }

        public int JobTitleId { get; set; }
        public JobTitle JobTitle { get; set; }
    }
}
