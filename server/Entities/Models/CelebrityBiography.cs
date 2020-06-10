using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebAPI.Models;

namespace Entities.Models
{
    public class CelebrityBiography
    {
        [Key]
        [ForeignKey("Celebrity")]
        public int CelebrityId { get; set; }
        public string ChildhoodAndYouth { get; set; }
        public string ChildhoodAndYouthImage { get; set; }
        public string PersonalLife { get; set; }
        public string PersonalLifeImage { get; set; }
        public string CareerInCinema { get; set; }
        public string CareerInCinemaImage { get; set; }

        public Celebrity Celebrity { get; set; }
    }
}
