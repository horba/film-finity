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
        public string Birthday { get; set; }
        public string PlaceOfBirthday { get; set; }
        public string StarSing { get; set; }
        public string Height { get; set; }
        public string FamilyStatus { get; set; }
        public string Achievement { get; set; }
        public Dictionary<string, double> Rates { get; set; }
        public NetworkingSitesDTO NetworkingSites { get; set; }
        public string Biography { get; set; }
    }
}
