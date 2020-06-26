using Entities.Models;
using Microsoft.AspNetCore.Mvc.Internal;
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

        public string Birthday { get; set; }
        public string PlaceOfBirthday { get; set; }
        public string StarSing { get; set; }
        public string Height { get; set; }
        public string FamilyStatus { get; set; }
        public string Achievement { get; set; }

        public ICollection<CelebrityJobTitles> CelebrityJobTitles { get; set; }
<<<<<<< HEAD
        public CelebrityNetworkingSites CelebrityNetworkingSites { get; set; }
        public CelebrityBiography CelebrityBiography { get; set; }
=======
        public ICollection<SerialCelebrity> SerialCelebrity { get; set; }
>>>>>>> dev
    }
}
