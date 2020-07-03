using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public ICollection<ActorsList> ActorsList { get; set; }
    }
}
