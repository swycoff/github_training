using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class ArrayExamples
    {
        public void createArrays()
        {
            int[] twoSlotIntArray = new int[2];
            twoSlotIntArray[0] = 1;
            twoSlotIntArray[1] = 2;

            string[] twoSlotStringArray = new string[2] { "Alex", "Ethan" };

        }
        public void compareArraysForDuplicates()
        {
            int[] intArray1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] intArray2 = new int[5] { 1, 3, 5, 7, 9 };

            int countArray1 = intArray1.Count();
            int countArray2 = intArray2.Count();

            //new array needs to be as big as the biggest array above as they could all be duplicates
            int largerCount;
            if (countArray1 > countArray2) { largerCount = countArray1; } else { largerCount = countArray2; }
            int[] newDupArray = new int[largerCount];

            int[] duplicateArray = new int[10];
            int i = 0;
            foreach(int array1Slot in intArray1)
            {
                foreach(int array2Slot in intArray2)
                {
                    if(array1Slot == array2Slot)
                    {
                        //add to the new array
                        newDupArray[i] = array1Slot;
                        i++;
                        break; // We have found a duplicate
                    }
                }
            }

            for(int a = 0; a < newDupArray.Count(); a++)
            {
                if(newDupArray[a] != 0)
                {
                    Console.WriteLine(newDupArray[a].ToString());
                }
                
                
            }
            Console.ReadLine();


        }
    }
}
