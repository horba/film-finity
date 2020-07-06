using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Models;

namespace Entities.Models
{
    public class VideoFile
    {
        public int Id { get; set; }
        public string TrailerLink { get; set; }
        public Movie Movie { get; set; }
    }
}
