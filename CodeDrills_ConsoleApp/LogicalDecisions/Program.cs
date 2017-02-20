using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int x = 3;
            string astring = "abc";
            bool conditionA = false;
            int numberToCompare = 2;

            if (x == 1) { /* perform an action */}
            else if (x == 2) { /* perform an action */}
            else { /* perform an action if first two conditions not met*/}

            for (int i = 0; i < 10; i++) {  /*Do something 10 times */}

            foreach (char s in astring) { /*loop through each character in the string*/  }
                        
            while(conditionA == false) { /* will loop until you set conditionA = true */ }
            
            switch (numberToCompare)
            {
                case 1:
                    //do something
                    break;
                case 2:
                    //Do something else
                    break;
            }

            //this will execute once
            do { if (x == 3) { x = 2; } }
            while (x == 3);

            //Logical Conditions
            //&&
            //||

            //LOOP CONTROL STATEMENTS
            //Continue - Causes the loop to skip the remainder of its body and immediately retest its condition prior to reiterating.
            //Break - Terminates the loop or switch statement and transfers execution to the statement immediately following the loop or switch.
            //Return - Exits the current method.


        }
    }
}
