using CsvHelper;
using MovieAPI.Mappers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.Services
{
    public class Metadata
    {
        // Creates a Movie Metadata
        public void CreateMovie(string path, Models.Metadata movie)
        {

            using (StreamWriter sw = new StreamWriter(path, true, new UTF8Encoding(true)))
            using (CsvWriter cw = new CsvWriter(sw))
            {
                cw.WriteRecord(movie);
                cw.NextRecord();
            }
        }

        // Get Movie Metadata
        public List<Models.Metadata> GetMetadata(string location, int movieId)
        {
            using (var reader = new StreamReader(location, Encoding.Default))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.RegisterClassMap<MetadataMap>();
                var records = csv.GetRecords<Models.Metadata>().Where(m => m.movieId == movieId).ToList();

                return records;

            }
        }
    }
}