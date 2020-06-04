using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string ActorName { get; set; }

        public ICollection<ActorsList> ActorsList { get; set; }
    }
}
