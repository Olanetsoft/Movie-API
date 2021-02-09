using CsvHelper;
using MovieAPI.Mappers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.Services
{
    public class Movies
    {

        // Get Movie Stats
        public List<Models.Movie> GetMovies(string location)
        {
            using (var reader = new StreamReader(location, Encoding.Default))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.RegisterClassMap<MovieMap>();
                var records = csv.GetRecords<Models.Movie>().OrderByDescending(mw => mw.watchDurationMs).ToList();
                return records;

            }
        }

    }
}
