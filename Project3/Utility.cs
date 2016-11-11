using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Project3
{
    public class Utility
    {
        /// <summary>
        /// Builds a list of movies from the 'models/movies.json' file 
        /// </summary>
        /// <returns>A List of Movies</returns>
        public static List<Movie> GetMovieList()
        {
            List<Movie> movies = new List<Movie>();

            // reference to json file
            string myFile = Directory.GetCurrentDirectory() + "/models/movies.json";
            // read file Contents & populate list
            var fileContents = File.ReadAllText(myFile);
            movies = JsonConvert.DeserializeObject<List<Movie>>(fileContents);

            foreach (Movie m in movies)
            {
                // generate the resource name from the movie title
                string resourceName = m.Title.ToLower().Replace(" ", "_");
                // set the poster 
                m.Poster = new System.Drawing.Bitmap((Bitmap)Properties.Resources.ResourceManager.GetObject(resourceName));
            }

            return movies;
        }
              

    }
}
