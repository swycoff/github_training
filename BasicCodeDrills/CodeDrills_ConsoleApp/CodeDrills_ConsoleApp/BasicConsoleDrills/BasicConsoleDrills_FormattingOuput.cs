using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDrills_ConsoleApp
{
    class BasicConsoleDrills_FormattingOuput
    {
        /// <summary>
        /// Repeating one number entered in different formats to the console
        /// </summary>
        public void repeatingNumbersInDifferentPatterns()
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number + " " + number + " " + number + " " + number);
            Console.WriteLine("{0}{0}{0}{0}", number);
            Console.WriteLine(number + " " + number + " " + number + " " + number);
            Console.WriteLine("{0}{0}{0}{0}", number);

        }
        /// <summary>
        /// Maming one number repeat in three columns and 6 rows with row 2-5 only showing the first and third column.
        /// </summary>
        public void columnFormattingNumbers()
        {
            //Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0}{0}{0}", number);
        }
    }
}
