using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 25;
            string userName = "Jacob";

            bool isEqual = (age == 41); // the value of isEqual depends on the comparison in the ()
           
            bool userIsMichael = userName == "Michael"; // the value of this boolean is false. THE VALUE

            Console.WriteLine(userIsMichael);
            Console.WriteLine(isEqual);

            bool isNotEqual = age != 23; // != is "not equal"
            Console.WriteLine(isNotEqual);

            List<string> firstList = new List<string>(); //remember it needs a reference, aka above under using. LOOK for the LIGHTBLUB... ADD YOUR () at the end
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool listsAreEqual = (firstList == secondList); // () here is for clarity but not needed
            Console.WriteLine(listsAreEqual); // fasle but WHY? they are false because they are stored in a different place of memory. Think of Netflix and the user proflie. Like you can have the same favs but not shared between accounts. 

            bool isGreatThan = age > 36;
            Console.WriteLine(isGreatThan); //false

            bool isLessThan = age < 36;
            Console.WriteLine(isLessThan); // true

            bool isGreaterorEqual = age >= 41;
            Console.WriteLine(isGreaterorEqual); //false

            bool isTrue = true;
            bool isFalse = false;

            bool andValue = isTrue && isFalse; //true

            bool anotherAndValue = (age == 25 && userName == "Jacob"); // true
            bool orValue = (age == 25 || userName == "Michael"); // || is "or" ... TRUE, needs one to be true, even if the other is false. 
        }
    }
}
