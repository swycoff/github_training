using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDrills_PublicVsPrivateClass
{
    //Without specifying public the class is implicitly internal. 
    //This means that the class is only visible inside the same assembly. When you specify public, the class is visible outside the assembly.
    public class PublicClass_StaticAndNonStaticMethods
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

        #region Non Static methods
        //For you to be able to access these, you need an instance of this class.
        public void helloAndNameOutputToConsole_PublicClass_PublicMethod_NonStatic()
        {
            //Notes: Console is stored in the system class.
            string myName = "Shelley";
            Console.WriteLine("Hello:");
            Console.WriteLine(myName);
        }

        //This is private so you can not access this outside of this class even though its static.
        private void helloAndNameOutputToConsole_PublicClass__PrivateMethod_NonStatic()
        {
            //Notes: Console is stored in the system class.
            string myName = "Shelley";
            Console.WriteLine("Hello:");
            Console.WriteLine(myName);
        }
        //This assumes the lowest level of access (private) so even though its static you 
        //won't be able to access it outside of this class.
        void helloAndNameOutputToConsole_PublicClass_NonStatic()
        {
            //Notes: Console is stored in the system class.
            string myName = "Shelley";
            Console.WriteLine("Hello:");
            Console.WriteLine(myName);
        }
        #endregion

    }
}
