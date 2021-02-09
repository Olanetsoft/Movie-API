using CsvHelper.Configuration;
using MovieAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Mappers
{
    public sealed class MovieMap : ClassMap<Movie>
    {
        public MovieMap()
        {
            Map(x => x.movieId).Name("movieId");
            Map(x => x.watchDurationMs).Name("watchDurationMs");
        }
    }


}
