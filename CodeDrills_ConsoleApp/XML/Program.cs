using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //XMLParsing xmlparse = new XMLParsing();
            //xmlparse.parseStudentXML();

            XMLCreation xmlCreate = new XMLCreation();
            xmlCreate.CreateXMLFileFromCSV();
        }
    }
}
