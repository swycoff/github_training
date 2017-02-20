using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//reading a file
using System.Xml.Linq; // Making the XML file

namespace XMLExamples
{
    class XMLCreation
    {
        public void CreateXMLFileFromCSV()
        {
            string path = @"C:\Users\swycoff\Google Drive\CodeDrills\CodeDrills_ConsoleApp\XML\Files\studentInfo.csv";
            string[] lines = File.ReadAllLines(path);

            XElement xml = new XElement("Root",
                from str in lines
                let columns = str.Split(',')
                select new XElement("Student",
                new XElement("Student_Firstname", columns[0]),
                new XElement("Student_MiddleName", columns[1]),
                new XElement("Student_LastName", columns[2]),
                new XElement("Student_Username", columns[3]),
                new XElement("Student_SISID", columns[4]),
                new XElement("Student_DBID", columns[5]),
                new XElement("Student_GradeDBID", columns[6])
                )

                );
            xml.Save(@"C:\Users\swycoff\Google Drive\CodeDrills\CodeDrills_ConsoleApp\XML\Files\studentInfoXML.xml");
        }
        
    }
}
