using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDrills_ConsoleApp.IO_Operations
{
    class binaryReaderAndWriter
    {
        //The BinaryWriter and System.IO.BinaryReader classes are used for writing and reading data rather than character strings.   
        public const string FILE_NAME = @"C:\Users\swycoff\Documents\Training\textFiles\binaryFiles\binary1.data";
        
        /// <summary>
        /// Reading the file with the file stream and binary reader class
        /// </summary>
        public void readFromBinaryFile()
        {
            //Check to make sure the file exists
            if(File.Exists(FILE_NAME))
            {
                using (FileStream fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader r = new BinaryReader(fs))
                    {
                        for (int i = 0; i < 11; i++)
                        {
                            Console.WriteLine(r.ReadInt32());
                        }
                    }
                }
            }
            
        }
        /// <summary>
        /// Writing to the file with the file stream and binary writer class
        /// </summary>
        public void writeToBinaryFile()
        {
            ////stop if it exists already
            //if (File.Exists(FILE_NAME))
            //{
            //    Console.WriteLine("{0} already exists!", FILE_NAME);
            //    return;
            //}
            //if it doesn't exist, create it with the Filestream Object and Binary Writer Object
            //This writes 0 to 10 into the file.
            using (FileStream fs = new FileStream(FILE_NAME, FileMode.CreateNew))
            {
                using (BinaryWriter w = new BinaryWriter(fs))
                {
                    for (int i = 0; i < 11; i++)
                    {
                        w.Write(i);
                    }
                }
            }

        }
        /// <summary>
        /// Check if file exists, if it doesn't, write to and then read from the file.
        /// </summary>
        public void writeToAndReadFromBinaryFile()
        {
            /*The BinaryWriter and System.IO.BinaryReader classes are used for writing and reading data rather than character strings. 
         * The following example demonstrates how to write data to, and read data from, a new, empty file stream called Test.data. 
         * After creating the data file in the current directory, the associated BinaryWriter and BinaryReader objects are created, 
         * and the BinaryWriter object is used to write the integers 0 through 10 to Test.data, which leaves the file pointer at the 
         * end of the file. After setting the file pointer back to the origin, the BinaryReader object reads out the specified content.
         * Source: https://msdn.microsoft.com/en-us/library/36b93480(v=vs.110).aspx
         * */

            //stop if it exists already
            if (File.Exists(FILE_NAME))
            {
                Console.WriteLine("{0} already exists!", FILE_NAME);
                return;
            }
            //if it doesn't exist, create it with the Filestream Object and Binary Writer Object
            //This writes 0 to 10 into the file.
            using (FileStream fs = new FileStream(FILE_NAME, FileMode.CreateNew))
            {
                using (BinaryWriter w = new BinaryWriter(fs))
                {
                    for (int i = 0; i < 11; i++)
                    {
                        w.Write(i);
                    }
                }
            }
            using (FileStream fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader r = new BinaryReader(fs))
                {
                    for (int i = 0; i < 11; i++)
                    {
                        Console.WriteLine(r.ReadInt32());
                    }
                }
            }
        }
    }
}
