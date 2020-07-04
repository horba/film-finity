using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FavoriteController : ControllerBase
    {
        private readonly IFavoriteService favoriteService;
        public FavoriteController(IFavoriteService favoriteService)
        {
            this.favoriteService = favoriteService;
        }

        [HttpGet("{page}")]
        public ActionResult<IEnumerable<FavoriteDTO>> GetListFavorites(int page=1)
        {
            IEnumerable<FavoriteDTO> objectList = favoriteService.GetFavorites(page);
            return Ok(objectList);
        }
    }
}