using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.DTO
{
    public class VideoFileDTO
    {
        public int Id { get; set; }
        public string TrailerLink { get; set; }
        public int MovieId { get; set; }
    }
}
