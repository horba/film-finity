using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WebAPI.HelpModels;

namespace WebAPI.DTO
{
    public class ReviewPagedRequest
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int UserId { get; set; }
        public ReviewSortState SortOrder { get; set; } = ReviewSortState.NameAsc;
        [MaxLength(50)]
        public string TitleName { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int PageSize { get; set; }
        [Range(1, int.MaxValue)]
        public int PageNumber { get; set; } = 1;
    }
}
