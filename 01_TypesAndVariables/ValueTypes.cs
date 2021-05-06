using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;

            isDeclared = true; // initalizing the variable

            bool isDeclaredAndInitialized = false; // both
        }

        [TestMethod]
        public void Characters()
        {
            char letter = 'a';
            char numberCharacter = '7';
            char symbol = '?';
            char space = ' ';
            char specialCharacter = '\t';
        }

        [TestMethod] // Write out "TestM" + Tab + Tab for shortcut
        public void WholeNumbers()
        {
            byte byteExample = 255;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;
        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.564652894981561654654464684f; //you need the 'f' at the end
            double doubleExample = 1.564652894981561654654464684d; //you need the 'd' at the end
            decimal decimalExample = 1.564652894981561654654464684m; //you need the 'm' at the end

            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample); //shortcut: cw + tab + tab
        }

        //enum is a class type, not like above
        enum PastryType { Cake, Cupcake, Eclaire, Danish, Canoli}

        [TestMethod]
        public void Enum()
        {
            PastryType myPastry = PastryType.Eclaire; // created our own type, ie PastryType
            PastryType anotherPastry = PastryType.Danish; // can still be Eclaire because it is a different name, ie anotherPastry
        }

        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            Console.WriteLine(DateTime.Now);
            DateTime birthday = new DateTime(1988, 04, 11);

            TimeSpan age = today - birthday;
            int ageInDays = age.Days;
            
            Console.WriteLine(ageInDays / 365);
        }
    }
}
