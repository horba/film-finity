using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTO;
using WebAPI.HelpModels;

namespace WebAPI.Services
{
    public interface IReviewsService
    {
        Entities.Models.IPagedResponse<ReviewDTO> GetReviews(int UserId, int PageNumber, int PageSize, ReviewSortState sortState);
        int? getReviewPage(int UserId, int PageNumber, int PageSize, ReviewSortState sortState, string titleName);
    }
}
