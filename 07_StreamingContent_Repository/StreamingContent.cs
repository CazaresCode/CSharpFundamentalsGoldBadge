using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository
{
    public enum GenreType { Horror = 1, RomCom, SciFi, Documentary, Bromance, Drama, Action, Comedy, Anime }
    public enum MaturityRating { G = 1, PG, PG_13, R, TV_G, TV_PG, TV_14, TV_MA }
    public class StreamingContent
    {
        //POCO - Plain old C# object
        //Object that holds some data
        //THIS IS THE BLUEPRINT of the Console App

        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public GenreType TypeOfGenre { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public bool IsFamilyFriendly
        {
            get
            {
                if (MaturityRating == MaturityRating.R || MaturityRating == MaturityRating.TV_MA)
                {
                    return false;
                }
                else
                {
                    return true;
                }
                //bool isFamilyFriendly = ((int)MaturityRating < 5) ? true : false; //Casting is taking the MR into an int and this is a condition in a ternary form. cast = convert to another (compatible) type.... THIS IS ANOTHER WAY TO DO IT, TOO.
            }
        }

        public StreamingContent () { }

        public StreamingContent (string title, string description, double starRating, GenreType typeOfGenre, MaturityRating maturityRating) // isFamilyFriendly not in this overloaded constructor because it was set up there.
        {
            Title = title;
            Description = description;
            StarRating = starRating;
            TypeOfGenre = typeOfGenre;
            MaturityRating = maturityRating;
        }
    }
}
