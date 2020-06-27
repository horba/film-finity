using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Models;

namespace Entities.Models
{
    public class SerialCelebrity
    {
        public int SerialId { get; set; }
        public Serial Serial { get; set; }
        public int CelebrityId { get; set; }
        public Celebrity Celebrity { get; set; }
    }
}
