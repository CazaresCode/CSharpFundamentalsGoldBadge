using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_Challenges
{
    [TestClass]
    public class Week1Challenges
    {
        [TestMethod]
        public void Challenges()
        {
            string word = "Supercalifragilisticexpialidocious";

            foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }

            foreach (char letter in word) //THIS IS A CONDITION of IfElseIfStatements
            {
                if (letter == 'i') // char here needs ' ' NOT " "  & Look at the error for hints!
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    if (letter == 'L')
                    {
                        Console.WriteLine('L');
                    }
                    else if (letter != 'i' && letter != 'L')
                    {
                        Console.WriteLine("Not an i");
                    }
                }

            }

            //three different ways to show how many letters/char's are there in the word

            //to count the characters, use what is below:
            int numLetters = word.Length;
            {
                Console.WriteLine(numLetters);
            }

            //Another way to count the letters:
            Console.WriteLine(word.Length);
           
            int letterCount = 0;
            foreach (char letter in word)
            {
                ++letterCount;
                    //letterCount += 1;
                    //letterCount = letterCount + 1;
            }
            Console.WriteLine(letterCount);


        }

        //BONUS
        [TestMethod]
        public void UserOneTests()
        {
            User userOne = new User("Alexandro", "Cazares", 12345, "ac@me.com", new DateTime(1993, 08, 26));

            Console.WriteLine($"{userOne.FullName()}");

            Console.WriteLine($"{userOne.FullName()} is {userOne.Age}!"); // This method is going to User.cs to public string FullName to look at the get { }, which contains   return $"{FirstName} {LastName}";   SO that it comes back to this place. THEN, it goes back for Age, which takes the userOne's BirthDate value and goes through the calucation. MUST have return so it comes back to this place. 
        }
    }
}
