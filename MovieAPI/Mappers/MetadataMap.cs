using CsvHelper.Configuration;
using MovieAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TinyCsvParser.Mapping;

namespace MovieAPI.Mappers
{
    public sealed class MetadataMap : ClassMap<Metadata>
    {
        public MetadataMap()
        {
            Map(x => x.movieId).Name("MovieId");
            Map(x => x.title).Name("Title");
            Map(x => x.language).Name("Language");
            Map(x => x.duration).Name("Duration");
            Map(x => x.releaseYear).Name("ReleaseYear");
        }
    }
}

