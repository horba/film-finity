using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebAPI.Models;

namespace Entities.Models
{
    public class CelebrityNetworkingSites
    {
        [Key]
        [ForeignKey("Celebrity")]
        public int CelebrityId { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }

        public Celebrity Celebrity { get; set; }
    }
}
