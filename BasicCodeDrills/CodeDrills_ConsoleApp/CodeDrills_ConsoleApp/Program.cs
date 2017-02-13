using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDrills_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //BasicConsoleDrills_Numbers BCD_Numbers = new BasicConsoleDrills_Numbers();
            //BCD_Numbers.GetCombinations_IncludeDuplicates();

            ParsingXMLFiles pXML = new ParsingXMLFiles();
            pXML.parseXMLFile();
        }
    }
}
