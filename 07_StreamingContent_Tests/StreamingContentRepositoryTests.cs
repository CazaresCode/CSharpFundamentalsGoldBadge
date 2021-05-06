using _07_StreamingContent_Repository;
using _07_StreamingContent_Repository.Content;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _07_StreamingContent_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests //names are usually long here
    {
        private StreamingContent _content;  //Declaring variables outside in the fields
        private StreamingContentRepository _repo;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Back to the Future", "A high school student named Marty gets accidentally sent back in time 30 years.", 4.4, GenreType.SciFi, MaturityRating.PG);
            _repo.AddContentToDirectory(_content);
        }

        [TestMethod]
        public void CheckMovieRunTime()
        {
            // Creating a movie type using full constructor and inherited base.
            Movie joe = new Movie("Joe Dirt", "The story about a mullet and his meteor", 3.2, GenreType.Bromance, MaturityRating.PG_13, 112);
            // Creating a list to replicate our repo
            List<StreamingContent> miniRepo = new List<StreamingContent>();
            miniRepo.Add(joe);

            //Filtering our repo by Movies in our foreach
            foreach (Movie content in miniRepo)
            {
                Console.WriteLine(content.RunTime);
            }

            //Searching for StreamingContent makes run time unavaible without casting.
            foreach (StreamingContent content in miniRepo)
            {
                //Finding movie types.
                if (content is Movie)
                {
                    //Setting content as Movie to access Movie exclusive properties.
                Console.WriteLine((content as Movie).RunTime);
                    //Console.WriteLine(((Movie) content).RunTime); //another way to do the cw

                }
            }
        }



        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //AAA
            //Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            //Act
            bool addResult = repository.AddContentToDirectory(content);

            //Assert
            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();
            repository.AddContentToDirectory(content);

            //Act
            List<StreamingContent> directory = repository.GetContents(); //We had to use ctrl + . to add the Generic system above because it is a new class

            //Assert
            bool directoryHasContent = directory.Contains(content); //content is the list... Contains is a built in method for Lists
            Assert.IsTrue(directoryHasContent);
        }

        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange
            //Done in Arrange() method ... which is the Test Initialize method

            //Act
            StreamingContent searchResult = _repo.GetContentByTitle("Back to the Future");

            //Assert
            Assert.AreEqual(_content, searchResult);
        }

        [TestMethod]
        public void UpdateExistingContent_ShouldReturnUpdatedValue()
        {
            //Arrange
            //Already done in Arrange() method... just like in GetByTitle_ShouldReturnCorrectContent

            //Act
            _repo.UpdateExistingContent("Back to the Future", new StreamingContent("Back to the Future 2", "Marty goes into the future 30 years", 4.0, GenreType.SciFi, MaturityRating.PG_13));

            //Assert
            Assert.AreEqual(_content.Title, "Back to the Future 2");
        }

        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            bool wasDeleted = _repo.DeleteExistingContent("back to the FUTURE");

            Assert.IsTrue(wasDeleted);
        }

    }
}
