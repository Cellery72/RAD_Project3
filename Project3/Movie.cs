using System.Drawing;
using Newtonsoft.Json;

namespace Project3
{
    public class Movie
    {
        [JsonProperty("Title")]
        public string Title { get; set; }
        [JsonProperty("Genre")]
        public string Genre { get; set; }
        [JsonProperty("Price")]
        public double Price { get; set; }
        public Bitmap Poster { get; set; }
    }
}
