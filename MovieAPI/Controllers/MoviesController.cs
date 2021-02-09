using Microsoft.AspNetCore.Mvc;
using MovieAPI.Models;
using MovieAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Controllers
{
    [Route("[controller]/stats")]
    [ApiController]

    public class MoviesController : Controller
    {

        private Movies _movieService;

        // Constructor
        public MoviesController(Movies movieService)
        {
            _movieService = movieService;
        }


        // GET Movie Stat
        // api/movie/stat
        [HttpGet]
        public IActionResult GetMovieStat()
        {
            var path = @"./Data/stats.csv";

            // get metadata
            var metadata = _movieService.GetMovies(path);

            return Ok(metadata);
        }
    }
}
