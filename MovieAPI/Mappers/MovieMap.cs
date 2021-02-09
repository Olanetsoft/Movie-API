using CsvHelper.Configuration;
using MovieAPI.Models;
using MovieAPI.Utils;
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
            Map(x => x.movieId).Name(GlobalStrings.Movie.MovieId);
            Map(x => x.watchDurationMs).Name(GlobalStrings.Movie.WatchDurationMs);
        }
    }


}
