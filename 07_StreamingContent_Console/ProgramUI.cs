using _07_StreamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Console
{
    public class ProgramUI
    {
        private StreamingContentRepository _repo = new StreamingContentRepository(); //naming convention for field begins with _ (underscore)
        public void Run() //accessible to the class 
        {
            SeedContentList(); //this is at the bottom which helps up run the method and act like a place holder to test the methods. You can comment it out to not have it in the repo, too. 
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select a menu option:\n" + // \n is a line break WITHIN the ""
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content \n" +
                    "6. Exit");

                string input = Console.ReadLine();

                switch (input.ToLower()) //input is what we are going to evulate
                {
                    case "1":
                    case "one":
                    case "banana": // just showing you can type anything here
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
                        Console.WriteLine("Please enter a vaild number");
                        break;
                }


                //Another option
                //if (input =="1" || input.ToLower() == "one")
                //{

                //}


                Console.WriteLine("Please press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void CreateNewContent() // optional challenge - ask the user to confirm information before ading to directory
        {
            Console.Clear();
            StreamingContent newContent = new StreamingContent(); //StreamingContent() = "StreamingContent Object"

            //Title
            Console.WriteLine("What is the title for this content?");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the description of the content.");
            newContent.Description = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter the Star Rating for this content (0.0 - 5.0)");
            string starRatingAsString = Console.ReadLine();
            double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            newContent.StarRating = starRatingAsDouble;

            //newContent.StarRating = Convert.ToDouble(Console.ReadLine()); // same as the three lines above

            //Genre Type
            Console.WriteLine("Enter the Genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            string genreAsString = Console.ReadLine(); //capturing the user's input... remember, it captures as a string.
            int genreAsInt = Convert.ToInt32(genreAsString); //converting to int from the string
            newContent.TypeOfGenre = (GenreType)genreAsInt; //we are casting to the type, in this case, it is the GenreType

            //Maturity Rating
            Console.WriteLine("Enter the Maturity Rating number for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG_13\n" +
                "4. R\n" +
                "5. TV_G\n" +
                "6. TV_PG\n" +
                "7. TV_PG14\n" +
                "8. TV_MA\n");

            newContent.MaturityRating = (MaturityRating)Convert.ToInt32(Console.ReadLine());

            //Below is another example of a shorter answer
            //string maturityRatingAsString = Console.ReadLine();
            //int maturityRatingAsInt = Convert.ToInt32(maturityRatingAsString);
            //newContent.MaturityRating = (MaturityRating)maturityRatingAsInt;


            bool wasAddedCorrectly = _repo.AddContentToDirectory(newContent); //this needs a field so we can access it. 
            if (wasAddedCorrectly)
            {
                Console.WriteLine("The content was added correctly.");
            }
            else
            {
                Console.WriteLine("Could not add the content.");
            }
        }

        private void DisplayAllContent() // optional challenge - Display all content in the directory
        {
            Console.Clear();
            List<StreamingContent> allContent = _repo.GetContents();
            foreach (StreamingContent content in allContent) //StreamingContent is the type and content is the value.
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Title: {content.Title}\n" + //only showing 2 properities 
                    $"Is Family Friendly: {content.IsFamilyFriendly}");
                Console.ResetColor();
            }
        }

        private void DisplayContentByTitle() //get a title from the user then display all properties of the content that has that title.
        {
            Console.Clear();
            DisplayAllContent();

            Console.WriteLine("Enter the title for the content you would like to see?");
            StreamingContent matchedContent = _repo.GetContentByTitle(Console.ReadLine());

            if (matchedContent != null)
            {
                Console.Clear();
                Console.WriteLine($"Title: {matchedContent.Title}\n" +
                    $"Description: {matchedContent.Description}\n" +
                    $"Star Rating: {matchedContent.StarRating}\n" +
                    $"Type of Genre: {matchedContent.TypeOfGenre}\n" +
                    $"Maturity Rating: {matchedContent.MaturityRating}\n" +
                    $"Is Family Friendly: {matchedContent.IsFamilyFriendly}");
                //matchedContent is helpful to know that it is the local variable and descripitve 
            }
            else
            {
                Console.WriteLine("There is no content by that title.");
            }
        }

        private void UpdateContent()
        {
            Console.Clear();
            DisplayAllContent();
            Console.WriteLine("Enter the title you would like to update.");

            string oldTitle = Console.ReadLine();

            //below is a copy and paste from above. You could create a method that can be accessible here and above. Remember DRY code!

            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("What is the new title for this content?");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the new description of the content.");
            newContent.Description = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter the new Star Rating for this content (0.0 - 5.0)");
            string starRatingAsString = Console.ReadLine();
            double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            newContent.StarRating = starRatingAsDouble;

            //newContent.StarRating = Convert.ToDouble(Console.ReadLine()); // same as the three lines above

            //Genre Type
            Console.WriteLine("Enter the new Genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            string genreAsString = Console.ReadLine(); //capturing the user's input... remember, it captures as a string.
            int genreAsInt = Convert.ToInt32(genreAsString); //converting to int from the string
            newContent.TypeOfGenre = (GenreType)genreAsInt; //we are casting to the type, in this case, it is the GenreType

            //Maturity Rating
            Console.WriteLine("Enter the new Maturity Rating number for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG_13\n" +
                "4. R\n" +
                "5. TV_G\n" +
                "6. TV_PG\n" +
                "7. TV_PG14\n" +
                "8. TV_MA\n");

            newContent.MaturityRating = (MaturityRating)Convert.ToInt32(Console.ReadLine());

            bool wasUpdated = _repo.UpdateExistingContent(oldTitle, newContent); //added "bool wasUpdated" to double check
            if (wasUpdated)
            {
                Console.WriteLine("The content was updated successfully!");
            }
            else
            {
                Console.WriteLine("No Contenet by that title exists"); //this method should go earlier because it catches too far into the process
            }

        }

        private void DeleteContent()
        {
            Console.Clear();
            DisplayAllContent();

            Console.WriteLine("Enter the title for the content you want to delete.");

            bool wasDeleted = _repo.DeleteExistingContent(Console.ReadLine());

            if (wasDeleted) //remember this means that wasDeleted == true.
            {
                Console.WriteLine("Your content was successfully deleted!");
            }
            else
            {
                Console.WriteLine("Content could not be deleted.");
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

