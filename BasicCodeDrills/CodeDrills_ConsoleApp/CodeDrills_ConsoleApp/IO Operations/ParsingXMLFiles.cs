using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDrills_ConsoleApp
{
    class ParsingXMLFiles
    {
        public void parseXMLFile()
        {
            string path = @"C:\Users\swycoff\Google Drive\GitHub\github_training\BasicCodeDrills\CodeDrills_ConsoleApp\CodeDrills_ConsoleApp\Files\SampleXMLFile1.xml";

            //variables to hold the data coming out of the XML File

            string student_FirstName = "";
            string student_MiddleName = "";
            string student_LastName = "";
            string student_UserName = "";
            string passWord = "";
            string student_sISID;
            int student_DBUserID;

            //Xpath loads the XML document we specified in the path above into a list of objects we can enumerate over
            XElement xelement2 = XElement.Load(path);
            IEnumerable<XElement> StudentBenchmarkUsers = xelement2.Elements();

            foreach (var user in StudentBenchmarkUsers)
            {
                student_FirstName = user.Element("Student_Firstname").Value;
                student_MiddleName = user.Element("Student_MiddleName").Value;
                student_LastName = user.Element("Student_LastName").Value;
                student_UserName = user.Element("Student_Username").Value;
                student_sISID = user.Element("Student_SISID").Value;
                student_DBUserID = Convert.ToInt32(user.Element("Student_DBID").Value);

                //This is the ideal spot to add to an object and then add them to a list of that kind of object

                //For now we will report to the console to keep the clutter down.
                Console.WriteLine("");
                Console.WriteLine("STUDENT:");
                Console.WriteLine("Firstname: " + student_FirstName);
                Console.WriteLine("Middlename: " + student_MiddleName);
                Console.WriteLine("LastName: " + student_LastName);
                Console.WriteLine("Username: " + student_UserName);
                Console.WriteLine("SISID: " + student_sISID);
                Console.WriteLine("DBUserID" + student_DBUserID);

            }

        }
        

    }
}
