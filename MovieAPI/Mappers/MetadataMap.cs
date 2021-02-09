using CsvHelper.Configuration;
using MovieAPI.Models;
using MovieAPI.Utils;
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
            Map(x => x.movieId).Name(GlobalStrings.Metadata.MovieId);
            Map(x => x.title).Name(GlobalStrings.Metadata.Title);
            Map(x => x.language).Name(GlobalStrings.Metadata.Language);
            Map(x => x.duration).Name(GlobalStrings.Metadata.Duration);
            Map(x => x.releaseYear).Name(GlobalStrings.Metadata.ReleaseYear);
        }
    }
}

