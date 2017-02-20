using System;
using System.Collections.Generic; // This is the class that works with lists
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class genericLists
    {
        //Functions available here: https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.110).aspx

        public void genericStringList()
        {
            //Notice no size has to be specified it dynamically expands itself
            List<string> newStringList = new List<string>();

            newStringList.Add("abc");
            newStringList.Add("def");

            foreach(string st in newStringList)
            {
                Console.WriteLine("This is the string in the list: " + st);
            }
            Console.ReadLine();

            //Note you can make lists of objects (like a student object) as well, not just ints and strings.  
            //It would look something like this: parts.Add(new Part() {PartName="crank arm", PartId=1234});

        }

      
    }
}
