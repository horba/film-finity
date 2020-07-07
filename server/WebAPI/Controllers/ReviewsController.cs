using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using Entities.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            var objectList = _reviewsService.GetReviews(reviewPaged.UserId, reviewPaged.PageNumber, reviewPaged.PageSize);
            return Ok(objectList);
        }
    }
}