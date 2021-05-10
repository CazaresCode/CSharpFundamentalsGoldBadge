using _07_StreamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_UIRefactor.UI
{
    public class ProgramUI
    {
        private StreamingContentRepository _repo = new StreamingContentRepository();
        private IConsole _console;

        public ProgramUI (IConsole console)
        {
            _console = console;
        }

        public void Run() 
        {
            SeedContentList(); 
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                _console.WriteLine(DateTime.Now);
                _console.WriteLine("Select a menu option:\n" + 
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content \n" +
                    "6. Exit");

                string input = _console.ReadLine();

                switch (input.ToLower()) 
                {
                    case "1":
                    case "one":
                    case "banana": 
                        //CreateNewContent
                        CreateNewContent();
                        break;
                    case "2":
                    case "two":
                        //ViewAllContent
                        DisplayAllContent();
                        break;
                    case "3":
                    case "three":
                        //View Content By Title
                        DisplayContentByTitle();
                        break;
                    case "4":
                    case "four":
                        //Update existing content
                        UpdateContent();
                        break;
                    case "5":
                    case "five":
                        //Delete existing content
                        DeleteContent();
                        break;
                    case "6":
                    case "six":
                        //exit
                        keepRunning = false;
                        break;
                    default:
                        _console.WriteLine("Please enter a vaild number");
                        break;
                }


                //Another option
                //if (input =="1" || input.ToLower() == "one")
                //{

                //}


                _console.WriteLine("Please press any key to continue.");
                _console.ReadKey();
                _console.Clear();
            }
        }
        private void CreateNewContent() // optional challenge - ask the user to confirm information before ading to directory
        {
            _console.Clear();
            StreamingContent newContent = new StreamingContent(); //StreamingContent() = "StreamingContent Object"

            //Title
            _console.WriteLine("What is the title for this content?");
            newContent.Title = _console.ReadLine();

            //Description
            _console.WriteLine("Enter the description of the content.");
            newContent.Description = _console.ReadLine();

            //Star Rating
            _console.WriteLine("Enter the Star Rating for this content (0.0 - 5.0)");
            string starRatingAsString = _console.ReadLine();
            double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            newContent.StarRating = starRatingAsDouble;

            //newContent.StarRating = Convert.ToDouble(_console.ReadLine()); // same as the three lines above

            //Genre Type
            _console.WriteLine("Enter the Genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            string genreAsString = _console.ReadLine(); //capturing the user's input... remember, it captures as a string.
            int genreAsInt = Convert.ToInt32(genreAsString); //converting to int from the string
            newContent.TypeOfGenre = (GenreType)genreAsInt; //we are casting to the type, in this case, it is the GenreType

            //Maturity Rating
            _console.WriteLine("Enter the Maturity Rating number for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG_13\n" +
                "4. R\n" +
                "5. TV_G\n" +
                "6. TV_PG\n" +
                "7. TV_PG14\n" +
                "8. TV_MA\n");

            newContent.MaturityRating = (MaturityRating)Convert.ToInt32(_console.ReadLine());

            //Below is another example of a shorter answer
            //string maturityRatingAsString = _console.ReadLine();
            //int maturityRatingAsInt = Convert.ToInt32(maturityRatingAsString);
            //newContent.MaturityRating = (MaturityRating)maturityRatingAsInt;


            bool wasAddedCorrectly = _repo.AddContentToDirectory(newContent); //this needs a field so we can access it. 
            if (wasAddedCorrectly)
            {
                _console.WriteLine("The content was added correctly.");
            }
            else
            {
                _console.WriteLine("Could not add the content.");
            }
        }

        private void DisplayAllContent() // optional challenge - Display all content in the directory
        {
            _console.Clear();
            List<StreamingContent> allContent = _repo.GetContents();
            foreach (StreamingContent content in allContent) //StreamingContent is the type and content is the value.
            {
                //Console.ForegroundColor = ConsoleColor.Green;
                _console.WriteLine($"Title: {content.Title}\n" + //only showing 2 properities 
                    $"Is Family Friendly: {content.IsFamilyFriendly}");
                //Console.ResetColor();
            }
        }

        private void DisplayContentByTitle() //get a title from the user then display all properties of the content that has that title.
        {
            _console.Clear();
            DisplayAllContent();

            _console.WriteLine("Enter the title for the content you would like to see?");
            StreamingContent matchedContent = _repo.GetContentByTitle(_console.ReadLine());

            if (matchedContent != null)
            {
                _console.Clear();
                _console.WriteLine($"Title: {matchedContent.Title}\n" +
                    $"Description: {matchedContent.Description}\n" +
                    $"Star Rating: {matchedContent.StarRating}\n" +
                    $"Type of Genre: {matchedContent.TypeOfGenre}\n" +
                    $"Maturity Rating: {matchedContent.MaturityRating}\n" +
                    $"Is Family Friendly: {matchedContent.IsFamilyFriendly}");
                //matchedContent is helpful to know that it is the local variable and descripitve 
            }
            else
            {
                _console.WriteLine("There is no content by that title.");
            }
        }

        private void UpdateContent()
        {
            _console.Clear();
            DisplayAllContent();
            _console.WriteLine("Enter the title you would like to update.");

            string oldTitle = _console.ReadLine();

            //below is a copy and paste from above. You could create a method that can be accessible here and above. Remember DRY code!

            StreamingContent newContent = new StreamingContent();

            //Title
            _console.WriteLine("What is the new title for this content?");
            newContent.Title = _console.ReadLine();

            //Description
            _console.WriteLine("Enter the new description of the content.");
            newContent.Description = _console.ReadLine();

            //Star Rating
            _console.WriteLine("Enter the new Star Rating for this content (0.0 - 5.0)");
            string starRatingAsString = _console.ReadLine();
            double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            newContent.StarRating = starRatingAsDouble;

            //newContent.StarRating = Convert.ToDouble(_console.ReadLine()); // same as the three lines above

            //Genre Type
            _console.WriteLine("Enter the new Genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            string genreAsString = _console.ReadLine(); //capturing the user's input... remember, it captures as a string.
            int genreAsInt = Convert.ToInt32(genreAsString); //converting to int from the string
            newContent.TypeOfGenre = (GenreType)genreAsInt; //we are casting to the type, in this case, it is the GenreType

            //Maturity Rating
            _console.WriteLine("Enter the new Maturity Rating number for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG_13\n" +
                "4. R\n" +
                "5. TV_G\n" +
                "6. TV_PG\n" +
                "7. TV_PG14\n" +
                "8. TV_MA\n");

            newContent.MaturityRating = (MaturityRating)Convert.ToInt32(_console.ReadLine());

            bool wasUpdated = _repo.UpdateExistingContent(oldTitle, newContent); //added "bool wasUpdated" to double check
            if (wasUpdated)
            {
                _console.WriteLine("The content was updated successfully!");
            }
            else
            {
                _console.WriteLine("No Contenet by that title exists"); //this method should go earlier because it catches too far into the process
            }

        }

        private void DeleteContent()
        {
            _console.Clear();
            DisplayAllContent();

            _console.WriteLine("Enter the title for the content you want to delete.");

            bool wasDeleted = _repo.DeleteExistingContent(_console.ReadLine());

            if (wasDeleted) //remember this means that wasDeleted == true.
            {
                _console.WriteLine("Your content was successfully deleted!");
            }
            else
            {
                _console.WriteLine("Content could not be deleted.");
            }
        }

        private void SeedContentList()
        {
            StreamingContent future = new StreamingContent("Back to the future", "Marty accidentally transported back in time 30 years.", 4.5, GenreType.SciFi, MaturityRating.PG);
            StreamingContent starWars = new StreamingContent("Star Wars", "Jar Jar saves the day.", 4.9, GenreType.SciFi, MaturityRating.PG_13);
            StreamingContent rubber = new StreamingContent("Rubber", "A care tire comes to life and goes on a killing spree.", .9, GenreType.Horror, MaturityRating.R);

            _repo.AddContentToDirectory(future);
            _repo.AddContentToDirectory(starWars);
            _repo.AddContentToDirectory(rubber);
        }
    }
}
