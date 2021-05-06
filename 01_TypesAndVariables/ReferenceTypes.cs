using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void Strings()
        {
            string firstName = "Alexandro"; //string needs quotes around the collection of different characters
            string lastName = "Cazares";

            //Concatenation 
            string conatenatedFullName = firstName + ' ' + lastName;
            Console.WriteLine(conatenatedFullName);

            //Compositing
            string compositeFullName = string.Format("{0} {1}", firstName, lastName); //CSharp is a Zero based counting, meaning it starts at Zero and not One
            Console.WriteLine(compositeFullName);

            //Interpolation
            string interpolatedFullName = $" {firstName} \"Boubou\" {lastName} is the best..."; // $ is forming a string, like forming a sentence
            Console.WriteLine(interpolatedFullName);
        }


        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello World";

            string[] stringArray = { "Hello", "World!", "Why", "is it", "always", stringExample, "?" }; // string[] is string Array AND you cannot add to the strings later on, but you can change the value.

            string firstString = stringArray[0]; //this will grab the first string from stringArray above and make it now firstString, which is now "Hello"
            Console.WriteLine(firstString);

            string interpolatedStrings = $"{stringArray[2]} {stringArray[5]}";
            Console.WriteLine(interpolatedStrings);

            //Lists
            List<string> listOfStrings = new List<string>(); //created a new variable and gave it a new value with nothing in it, yet. Also, when doing this List<string>, click ctrl + .
            List<int> listOfIntegers = new List<int>();

            listOfStrings.Add("Hello");
            listOfIntegers.Add(23);
            listOfStrings.Add("World");
            Console.WriteLine(listOfIntegers[0]);
            Console.WriteLine(listOfStrings[1]);
            listOfStrings.Remove(listOfStrings[0]);
            Console.WriteLine(listOfStrings [0]);

            //Queues //can only hold one type, ie strings
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm First");
            firstInFirstOut.Enqueue("I'm next");
            firstInFirstOut.Enqueue("I'm last");

            string whosFirst = firstInFirstOut.Peek();
            Console.WriteLine(whosFirst);
            string firstItem = firstInFirstOut.Dequeue(); //nothing needs to go in the () because the first thing in is coming out
            Console.WriteLine(firstItem); //then we saved it to the firstItem because it was the first one in the Queue
            string whosFirstNow = firstInFirstOut.Peek(); //peek is see who is first in line without removing it
            Console.WriteLine(whosFirstNow);

            //Dictionaries
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>(); // remember to add () at the end! AND it is a pair of key and value together OR <key, value>

            keyAndValue.Add(001, "EFA office");

            string badgeDoor = keyAndValue[001]; //looking for an index of a very specific key, cannot work with value
            
            Console.WriteLine(badgeDoor);

            //SortedList
            //HashSet
            //Stack


          


        }
    }
}
