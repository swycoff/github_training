using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml; // needed for working with XML
using System.Xml.Linq; //needed for Xelements
using System.Text.RegularExpressions;



namespace XMLExamples
{
    class XMLParsing
    {
        public void parseStudentXML()
        {
            string path = @"C:\Users\swycoff\Google Drive\CodeDrills\CodeDrills_ConsoleApp\XML\Files\StudentXMLFile.xml";
            //Tells the XElement where to find the XML File
            XElement element1 = XElement.Load(path);
            //Loads all the elements into an enumerable list
            IEnumerable<XElement> studentUsers = element1.Elements();

            string firstName = "";
            string middleName = "";
            string lastName = "";
            string userName = "";
            string sisID = "";
            int dbUserID;
            int dbGradeID;
            foreach(var student in studentUsers)
            {
                firstName = student.Element("Student_Firstname").Value;
                middleName = student.Element("Student_MiddleName").Value;
                lastName = student.Element("Student_LastName").Value;
                userName = student.Element("Student_Username").Value;
                sisID = student.Element("Student_SISID").Value;
                dbUserID = Convert.ToInt32(student.Element("Student_DBID").Value);
                dbGradeID = Convert.ToInt32(student.Element("Student_GradeDBID").Value);
            }
        }
        
    }
}
