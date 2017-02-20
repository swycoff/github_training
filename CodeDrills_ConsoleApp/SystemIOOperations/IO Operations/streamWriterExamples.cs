using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SystemIOOperations
{
    class streamWriterExamples
    {
        string filePath = @"C:\Users\swycoff\Google Drive\CodeDrills\CodeDrills_ConsoleApp\TextFiles\SampleLogFile2.txt";

        public void streamWriterBasics()
        {
            //This doesn't check to see if a file exists, it just creates a new file.
            //If you run it again, it won't add lines to that file.
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("This is the only line to add to the file.");
            }
        }
        public void streamWriterAppendToFile()
        {
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine("This is the next line to add to the file.");
            }
        }





    }
}
