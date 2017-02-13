using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDrills_ConsoleApp.BasicConsoleDrills
{
    /* Reference: //http://www.w3resource.com/csharp-exercises/basic/index.php */
    class BasicConsoleDrills_Strings
    {
        /// <summary>
        /// Enter a string and output it to the console window
        /// </summary>
        public void enterStringAndOutput()
        {
            Console.WriteLine("Enter a string: ");
            string string1 = Console.ReadLine();
            Console.WriteLine("The string you entered is: " + string1);
        }
        /// <summary>
        /// Challenge 1: Output name and Hello to Console
        /// </summary>
        public void helloAndNameOutputToConsole()
        {
            //Notes: Console is stored in the system class.
            string myName = "Shelley";
            Console.WriteLine("Hello:");
            Console.WriteLine(myName);
        }
        /// <summary>
        /// Ouput you look older than.. the age the user entered.
        /// </summary>
        public void youLookOld()
        {
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look older than {0}", age);
        }
        /// <summary>
        /// Find the length of a string both with the library function and without.
        /// </summary>
        public void lengthOfString()
        {
            //Write a program in C# Sharp to find the length of a string without using library function
            Console.WriteLine("Enter a string");
            string string1 = Console.ReadLine();
            int stringLength = 0;
            foreach (char C in string1)
            {
                stringLength++;
            }
            Console.WriteLine("The length of the string you entered is: {0}", stringLength);

            //Now with using the library function
            stringLength = string1.Length;
        }
        /// <summary>
        /// Take a string and then make a new string that takes each character and puts a space between it.
        /// </summary>
        public void separateCharactersFromAString()
        {
            Console.WriteLine("Enter a string");
            string text = Console.ReadLine();
            string newText = "";
            foreach (char C in text)
            {
                newText += C + " ";
            }
            Console.WriteLine("The characters of the string spaced are: ");
            Console.WriteLine(newText);
        }
        /// <summary>
        /// Write the characters from a string in reverse order.
        /// </summary>
        public void writeCharactersInReverseOrder()
        {
            //Write a program in C# Sharp to print individual characters of the string in reverse order
            //Write a program in C# Sharp to separate the individual characters from a string.
            Console.WriteLine("Enter a string");
            string text = Console.ReadLine();

            Console.WriteLine("The characters of the string backwards are:");
            //because a string is an array of characters.
            int stringLength = text.Length - 1;
            while (stringLength >= 0)
            {
                Console.Write(text[stringLength]);
                stringLength--;
            }
            //OR
            for (stringLength = text.Length - 1; stringLength >= 0; stringLength--)
            {
                //arrays are 0 based and strings counts start at 1. 
                //that is why we have to -1 from the length.
                Console.Write(text[stringLength]);
            }

        }
        /// <summary>
        /// Identify the unique characters in a string.  For example BAN in bananna
        /// </summary>
        public void identifyUniqueCharactersInAString()
        {
            Console.WriteLine("Enter A String");
            string userInput = Console.ReadLine();

            //Only works for unicode characters
            //Creates a string class - which you need to initalize by using a pointer to an array.
            //First we give it the userInput and ask it to only use the distinct characters then we make those characters an array
            string uniqueCharacters1 = new String(userInput.Distinct().ToArray());
            //If we want to use these characters in the console window, they have to be formatted back into a normal string variable.
            //You can do that by using the string.join which takes each character in the arry and concats it into a string.
            string uniqueCharacters2 = string.Join("", uniqueCharacters1);
            Console.WriteLine("your unique characters are: " + uniqueCharacters2);

            //Console.WriteLine("You entered {0} and the original letters in that string are {1}", userInput, string.Join(string.Empty, uniqueCharacters1));

            //Alternative
            var newUserInput = new StringBuilder(userInput);
            foreach (char c in userInput)
            {
                newUserInput.Replace(c.ToString(), string.Empty);
                newUserInput.Append(c.ToString());

            }
        }
    }
}
