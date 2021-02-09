using Microsoft.AspNetCore.Mvc;
using MovieAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MetadataController : Controller
    {

        private Metadata _metadataService;

        // Constructor
        public MetadataController(Metadata metadataService)
        {
            _metadataService = metadataService;
        }


        // GET Metatada
        // api/metadata
        [HttpGet("{movieId}", Name = "GetMetadata")]
        public IActionResult GetMetadata(int movieId)
        {
            var path = @"./Data/metadata.csv";

            // get metadata
            var metadata = _metadataService.GetMetadata(path, movieId);

            return Ok(metadata);
        }


        //api/metadata
        [HttpPost]
        public IActionResult CreateMovie([FromBody] Models.Metadata movieToCreate)
        {
            var path = @"./Data/metadata.csv";

            // create metadata
            //var movie = _metadataService.CreateMovie(@"./Data/metadata.csv", movieToCreate);
            _metadataService.CreateMovie(path, movieToCreate);

            return CreatedAtRoute("GetMetadata", new { movieId = movieToCreate.movieId }, movieToCreate);
        }
    }
}
