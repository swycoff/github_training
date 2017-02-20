using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCodeDrills
{
    class IntermediateCode_Numbers
    {
        public void GetCombinations_AdditionNoDuplicates()
        {
            Console.WriteLine("Enter a number: ");
            int usersNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < usersNumber; i++)
            {
                /*Math Example
                 * Users Number Entered = 10
                 * 10+0 = 10
                 * 9+1 = 9
                 * 8+2 = 8
                 * 7+3 = 10
                 * 6+4 = 10
                 * 5+5 = 10
                 * 4+6 = 10 - notice that for an even number right after it hits 5=5 the equations turn into duplicates.
                 * 3+7 = 10
                 * 2+8 = 10
                 * 1+9 = 10
                 * 
                 * Users Number Entered = 11
                 * 11+0 = 11
                 * 10+1 = 11
                 * 9+2 = 11
                 * 8+3 = 11
                 * 7+4=11
                 * 6+5=11 // Notice that as soon as the numbers are one number apart the duplicates start.
                 * 5+6 = 11
                 * 4+7 =11
                 * 3+8 =11
                 * 2+9 =11
                 * 1+10 =11
                 */

                //The first number in the equation is i (starts at 0 and works its way up) - defined in the loop
                //The second number in the equation is the number entered by the user with the loop number subtracted from it (10-0, 9-1 etc.)
                int checkMidPoint = usersNumber - i;

                //For Even numbers we check to see if the second number in the equation is the same as the first. (5+5=10)
                //For Odd Numbers we check to see if the second number in the equation is one lower than the loop number (5+6)
                if (checkMidPoint == i || checkMidPoint == (i + 1))
                {
                    //We still need to write the last equation to the console (5+5 or 5+6 for example)
                    //But then we end.
                    Console.WriteLine("Combination {0}: {1} + {2} = {3}", i, usersNumber - i, i, usersNumber);
                    return;
                }
                else
                {
                    Console.WriteLine("Combination {0}: {1} + {2} = {3}", i, usersNumber - i, i, usersNumber);
                }
            }

        }
        public void GetCombinations_SubtractionNoDuplicates()
        {
            Console.WriteLine("Enter a number: ");
            int usersNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < usersNumber; i++)
            {
                int checkMidPoint = usersNumber - i;

                if (checkMidPoint == i || checkMidPoint == (i + 1))
                {
                    Console.WriteLine("Combination {0}: {1} - {2} = {3}", i, usersNumber + i, i, usersNumber);
                    return;
                }
                else
                {
                    Console.WriteLine("Combination {0}: {1} - {2} = {3}", i, usersNumber + i, i, usersNumber);
                }
            }

        }
        public void GetCombinations_AdditionDuplicates()
        {
            Console.WriteLine("Enter a number: ");
            int usersNumber = Convert.ToInt32(Console.ReadLine());

            #region Addition
            for (int i = 0; i < usersNumber; i++)
            {
                Console.WriteLine("Combination {0}: {1} + {2} = {3}", i, usersNumber - i, i, usersNumber);

            }
            #endregion

        }
    }
}
