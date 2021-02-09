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


        // GET Movies Stat
        // api/movies/stat
        [HttpGet]
        public IActionResult GetMovieStat()
        {
            var path = @"./Data/stats.csv";

            // get movies stats
            var movie = _movieService.GetMoviesStats(path);

            return Ok(movie);
        }
    }
}
