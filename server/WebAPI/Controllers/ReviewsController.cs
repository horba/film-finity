using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using Entities.Models;
using WebAPI.Services;
using WebAPI.HelpModels;
using Microsoft.AspNetCore.Authorization;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReviewsController : ControllerBase
    {

        private readonly IReviewsService _reviewsService;
        public ReviewsController(IReviewsService reviewsService)
        {
            this._reviewsService = reviewsService;
        }
        [HttpPost]
        [Route("Reviews")]
        public IActionResult GetReviewsByUserId(ReviewPagedRequest reviewPaged)
        {
            var objectList = _reviewsService.GetReviews(reviewPaged.UserId, reviewPaged.PageNumber, reviewPaged.PageSize, reviewPaged.SortOrder);
            return Ok(objectList);
        }
        [HttpPost]
        [Route("FindReview")]
        public IActionResult FindReviewPage(ReviewPagedRequest reviewPaged)
        {
            var pageNumber = _reviewsService.getReviewPage(reviewPaged.UserId, reviewPaged.PageNumber, reviewPaged.PageSize, reviewPaged.SortOrder, reviewPaged.TitleName);
            if (pageNumber != null)
            {
                return Ok(pageNumber);
            }
            return BadRequest(pageNumber);
        }
    }
}