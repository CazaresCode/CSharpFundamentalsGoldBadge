using _07_StreamingContent_Repository.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository
{
    public class StreamingContentRepository // acting like a database
    {
        private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>(); //name lists as _somethingOkay

        //CRUD methods below -- Create, Read, Update, Delete
        //Create
        //Content
        public bool AddContentToDirectory(StreamingContent newContent) //we are adding the newContent to the _contentDirectory below... WE ADDED AN error check with bool 
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(newContent);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Movie
        public bool AddContentToDirectory(Movie newContent)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(newContent);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Show

        //Episode

        //Read All
        //Content Read All
        public List<StreamingContent> GetContents() //simple method to get the contents so we dont want the front end to get our data... so this is an aroundabout way to get the list here
        {
            return _contentDirectory;
        }


        //Content Read All

        //Movie Read All
        public List<Movie> GetMovies()
        {
            // initialize empty list
            List<Movie> allMovies = new List<Movie>();
            //Look through our directory
            foreach (StreamingContent content in _contentDirectory)
            {
                // check if object is a Movie class
                if (content is Movie)
                {
                    // Load into our list
                    allMovies.Add(content as Movie); //remember, you can do (Movie)movie
                }
            }
            //return our list
            return allMovies;
        } //no need to add null because of the empty List above.

        //Show Read All
        public List<Show> GetShows()
        {
            //set up list
            List<Show> allShows = new List<Show>();
            //Find our shows
            foreach (StreamingContent content in _contentDirectory)
            {
                //check if it is a show
                if (content.GetType() == typeof(Show)) //similar to the one for GetMovies
                {
                    // Yes? Add to the list
                    allShows.Add((Show)content); //remember to cast the content as Show
                }
            }
            // Give shows back
            return allShows;
        }

        //Episode Read All

        //Get By Title
        //Content
        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }

        //Movie
        public Movie GetMovieByTitle(string title)
        {
            foreach (StreamingContent movie in _contentDirectory)
            {                                             // Using is to make sure movie 'is' of class type Movie
                if (movie.Title.ToLower() == title.ToLower() && movie is Movie) //the keyword is a boolean struct
                {
                    //Using 'as' as a way to cast, just as ' return (Movie)movie '
                    return movie as Movie;
                }
            }

            return null;
        }

        //Show
        //GetShowByTitle
        //Accessor - Return Type - Name (parameters)
        public Show GetShowByTitle(string title) // shows and movies are stored in the same _contentDirectory
        {
            foreach (StreamingContent show in _contentDirectory)
            {
                if (show.Title.ToLower() == title.ToLower() && show.GetType() == typeof(Show)) // .GetType is a method for objects, and make sure the GetType retrieves the right type because we have movies too. 
                {
                    return (Show)show;
                }
            }

            return null;
        }

        //Episode



        public bool UpdateExistingContent(string originalTitle, StreamingContent newContentValues)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            if (oldContent != null)
            {
                oldContent.Title = newContentValues.Title;
                oldContent.Description = newContentValues.Description;
                oldContent.StarRating = newContentValues.StarRating;
                oldContent.TypeOfGenre = newContentValues.TypeOfGenre;
                oldContent.MaturityRating = newContentValues.MaturityRating;

                return true;
            }
            else
            {
                return false;
            }
        }


        public bool DeleteExistingContent(string titleToDelete) //titleToDelete would be the input user.
        {
            StreamingContent contentToDelete = GetContentByTitle(titleToDelete); //contentToDelete is the one that is in the database.
            if (contentToDelete == null)
            {
                return false;
            }
            else
            {
                _contentDirectory.Remove(contentToDelete);
                return true;
            }
        }

    }
}
