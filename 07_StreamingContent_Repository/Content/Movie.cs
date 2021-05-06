using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository.Content
{
    public class Movie : StreamingContent
    {
        public Movie() { }
        public Movie(string title, string description, double stars, GenreType genre, MaturityRating maturityRating, double runTime) : base(title, description, stars, genre, maturityRating) // the stuff after the base is allowing us to save time from writing the props... it is looking at the parent properties or the first one in Streaming Content.
        {
            // Setting properties that aren't included in base constructor
            RunTime = runTime;
        }

        public double RunTime { get; set; }

    }
}
