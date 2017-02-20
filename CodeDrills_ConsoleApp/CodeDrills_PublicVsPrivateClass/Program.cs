using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDrills_PublicVsPrivateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //You can only access the one public static method this way.
            PublicClass_StaticAndNonStaticMethods.helloAndNameOutputToConsole_PublicClass_PublicStaticMethod();

            //You can only access the one public (non static) class with instatiation of that class.
            PublicClass_StaticAndNonStaticMethods publicClassInstance = new PublicClass_StaticAndNonStaticMethods();
            publicClassInstance.helloAndNameOutputToConsole_PublicClass_PublicMethod_NonStatic();

            //Notice the private classes or classes not marked with any accessor are not accessible 
            //regardless of static or not because you are outside of the class.

            //Becuase this whole class is marked static, you can only have static methods.
            //But you can include all kinds of accessors (public / private)
            //This is the only one available because its the only one marked public.
            PublicStaticClass_StaticOnlyMethodsAllowed.helloAndNameOutputToConsole_PublicClass_PublicStaticMethod();



        }
    }
}
