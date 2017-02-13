using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDrills_PublicVsPrivateClass
{
    //Because the class is static it doesn't allow any non Static methods to be here.
    //But it allows all types of public / private combinations
    public static class PublicStaticClass_StaticOnlyMethodsAllowed
    {
        #region Static Methods
        //public makes it accessible outside of this class.
        //static makes it available in memory without instantiating the class.
        public static void helloAndNameOutputToConsole_PublicClass_PublicStaticMethod()
        {
            //Notes: Console is stored in the system class.
            string myName = "Shelley";
            Console.WriteLine("Hello:");
            Console.WriteLine(myName);
        }
        //This is private so you can not access this outside of this class even though its static.
        private static void helloAndNameOutputToConsole_PublicClass_PrivateStaticMethod()
        {
            //Notes: Console is stored in the system class.
            string myName = "Shelley";
            Console.WriteLine("Hello:");
            Console.WriteLine(myName);
        }
        //This assumes the lowest level of access (private) so even though its static you 
        //won't be able to access it outside of this class.
        static void helloAndNameOutputToConsole_PublicClass_StaticMethod()
        {
            //Notes: Console is stored in the system class.
            string myName = "Shelley";
            Console.WriteLine("Hello:");
            Console.WriteLine(myName);
        }
        #endregion

      
      
       
    }
}
