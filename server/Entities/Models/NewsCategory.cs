using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class NewsCategory
    {
        public int NewsCategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}