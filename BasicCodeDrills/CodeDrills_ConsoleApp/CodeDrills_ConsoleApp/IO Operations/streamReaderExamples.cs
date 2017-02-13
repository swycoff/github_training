using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDrills_ConsoleApp.IO_Operations
{
    class streamReaderExamples
    {
        #region References
        //https://msdn.microsoft.com/en-us/library/36b93480(v=vs.110).aspx
        //https://www.dotnetperls.com/streamreader
        #endregion
        #region Using Statements, Get Root and Common StreamReader Methods
        /*USING STATEMENT
        *We use the StreamReader type inside a using-statement. This statement allows you to leave the 
        *file disposal and opening routines to the C# compiler's knowledge of scope.
        **/

        /*GET ROOT
        *Making it whatever the current directory is instead of specifying C or D
        *string driveLetter = Path.GetPathRoot(Environment.CurrentDirectory);
        */

        /* ReadLine
        * Reads the current line in the file
        * */

        /* ReadToEnd
         * Reads from the current position in the file to the end of the file.
         * */
        #endregion

        #region Class Level Variables
        string filePath = @"C:\Users\swycoff\Documents\Training\textFiles\SampleLogFile.txt";
        #endregion

        /// <summary>
        /// Check for File exists method
        /// </summary>
        public void streamReaderCheckForFileExists()
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine("{0} already exists!", filePath);
                return;
            }
        }

        /// <summary>
        /// Basic reading all of the file at once, with try catch for errors.
        /// </summary>
        public void streamReaderBasics()
        {

            try
            {
                // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(filePath))
                {
                    // Read the stream to a string, and write the string to the console.
                    string line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Read line by line looking for specific text
        /// </summary>
        public void streamReaderParseLargeFileForSpecificText()
        {
            StreamReader sr = new StreamReader(filePath);

            int lineNum = 1;
            string line = string.Empty;
            //peek: An integer representing the next character to be read, or -1 if there are no characters to be read or if the stream 
            //does not support seeking.  In other words it will return -1 when it reaches the end of the file.
            while (sr.Peek() != -1)
            {
                //reads the next line in the text.
                line = sr.ReadLine();

                if (line.Contains("Text I am Looking For"))
                {
                    Console.WriteLine("I found the text: " + line + " On Line Number: " + lineNum);
                }
                lineNum++;
            }

            Console.WriteLine(line); // do what you want with this line (parse using Regex)
        }

        /// <summary>
        /// Read the file and add each line to a list.  Output that list to the console.
        /// </summary>
        public void streamReaderAddEachLineToAList()
        {
            List<string> linesInFile = new List<string>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string linereturn = string.Empty;

                //stream reader returns null at the end of the file
                //Because each time you call readline it reads a line and moves forward in the file you have
                //to store what it reads into the variable here.
                while ((linereturn = sr.ReadLine()) != null)
                {
                    linesInFile.Add(linereturn);
                }

                Console.WriteLine("This is the contents of your file: ");
                foreach (string line in linesInFile)
                {
                    Console.WriteLine(line);
                }


            }
        }



    }
}
