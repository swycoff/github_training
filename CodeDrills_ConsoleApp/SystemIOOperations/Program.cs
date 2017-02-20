using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIOOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            streamWriterExamples sre = new streamWriterExamples();
           // sre.streamWriterBasics();
            sre.streamWriterAppendToFile();
        }
    }
}
