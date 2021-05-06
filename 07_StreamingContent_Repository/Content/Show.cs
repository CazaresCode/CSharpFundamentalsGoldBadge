using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository.Content
{
    public class Show : StreamingContent
    {
        // New up a list as a property, in case one doesn't exist.
        public List<Episode> Epsiodes { get; set; } = new List<Episode>(); //singular object is singular and pural is for the lists.

        public int SeasonCount { get; set; }
        public int EpisodeCount { get; set; }
        public double AverageRunTime { get; set; }


    }

    public class Episode //using this as a property as a show
    {
        public string Title { get; set; }
        public double RuntIme { get; set; }
        public int EpisodeNumber { get; set; }
        public int SeasonNumber { get; set; }
    }
}
