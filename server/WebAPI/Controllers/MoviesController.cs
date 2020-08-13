﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesService _moviesService;
        public MoviesController(IMoviesService moviesService)
        {
            this._moviesService = moviesService;
        }

        [HttpGet]
        public IActionResult GetListMovies()
        {
            var objectList = _moviesService.GetAllMovies();
            return Ok(objectList);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovieById(int id)
        {
            MovieDTO objectList = _moviesService.GetMovieById(id);
            return Ok(objectList);
        }

        [HttpGet("m/{id}")]
        public IActionResult GetMovie(int id)
        {
            var objectList = _moviesService.GetMovieDetails(id);
            return Ok(objectList);
        }
    }
}
