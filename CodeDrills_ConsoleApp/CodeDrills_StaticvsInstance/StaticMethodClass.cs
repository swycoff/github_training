using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDrills_StaticvsInstance
{
    class StaticMethodClass
    {
        //public makes it accessible outside of this class.
        //static makes it available in memory without instantiating the class.
        public static void helloAndNameOutputToConsoleStatic()
        {
            //Notes: Console is stored in the system class.
            string myName = "Shelley";
            Console.WriteLine("Hello:");
            Console.WriteLine(myName);
        }
    }
}
