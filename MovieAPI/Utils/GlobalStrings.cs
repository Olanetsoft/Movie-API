using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Utils
{
    public static class GlobalStrings
    {
        public static class Movie
        {
            public static readonly string MovieId = "movieId";
            public static readonly string WatchDurationMs = "watchDurationMs";
        }

        public static class Metadata
        {
            public static readonly string MovieId = "MovieId";
            public static readonly string Title = "Title";
            public static readonly string Language = "Language";
            public static readonly string Duration = "Duration";
            public static readonly string ReleaseYear = "ReleaseYear";
        }
    }
}
