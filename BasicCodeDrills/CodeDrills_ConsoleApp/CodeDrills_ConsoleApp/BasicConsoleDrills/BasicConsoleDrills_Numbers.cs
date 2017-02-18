using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDrills_ConsoleApp
{
    class BasicConsoleDrills_Numbers
    {
        /// <summary>
        /// Challege 2: Print the sum of two numbers given in the method.
        /// </summary>
        /// <param name="First"></param>
        /// <param name="Second"></param>
        public void printSumOfTwoNumbers(int First, int Second)
        {
            int sum = First + Second;
            //Three different ways to do this.
            Console.WriteLine("This is the sum of " + First + " + " + Second + " : " + sum);
            Console.WriteLine("This is the sum of {0} + {1} : {2}", First, Second, sum);
            Console.WriteLine(First + Second);
        }
        /// <summary>
        /// Challenge 2 / Advanced: Swap Two Numbers Given in the Method
        /// </summary>
        /// <param name="Num1"></param>
        /// <param name="Num2"></param>
        public void swapTwoNumbers(int Num1, int Num2)
        {
            int newFirstNum = Num2;
            int newSecondNum = Num1;
            Console.WriteLine(newFirstNum.ToString(), newSecondNum.ToString());

            //or
            int temp = Num2;
            int num1 = Num2;
            int num2 = num1;
            Console.WriteLine(num1.ToString(), num2.ToString());

        }
        /// <summary>
        /// Ask for Two Numbers to Swap
        /// </summary>
        public void askForTwoNumbersToSwap()
        {
            int num1, num2, temp;
            Console.WriteLine("\nEnter the first whole number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second whole number: ");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("\nThis is now number 1: {0}, and number 2: {1}", num1, num2);
        }
        /// <summary>
        /// Ask for two numbers to swap with simple error handling
        /// </summary>
        public void askForTwoNumbersToSwapWithErrorHandling_Simple()
        {
            try
            {
                int num1, num2, temp;
                Console.WriteLine("Enter the first whole number: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter the second whole number: ");
                num2 = int.Parse(Console.ReadLine());
                temp = num1;
                num1 = num2;
                num2 = temp;

                Console.WriteLine("This is now number 1: {0}, and number 2: {1}", num1, num2);
            }
            catch (Exception e)
            {
                Console.WriteLine("\nPlease Enter a WHOLE NUMBER, no decimals");
                askForTwoNumbersToSwapWithErrorHandling_Simple();
            }
        }
        /// <summary>
        /// Ask for two numbers to swap with line by line error handling
        /// </summary>
        public void askForTwoNumbersToSwapWithErrorHandling_LineByLine()
        {
            int num1 = 0;
            int num2 = 0;
            int temp = 0;
            bool number1Valid = false;
            bool number2Valid = false;

            while (!number1Valid)
            {
                try
                {
                    Console.WriteLine("Enter the first whole number: ");
                    num1 = int.Parse(Console.ReadLine());
                    number1Valid = true;
                }
                catch (Exception e)
                {
                    number1Valid = false;
                    Console.WriteLine("You entered an invalid number.");
                }

            }
            while (!number2Valid)
            {
                try
                {
                    Console.Write("Enter the second whole number: ");
                    num2 = int.Parse(Console.ReadLine());
                    number2Valid = true;
                }
                catch (Exception e)
                {
                    number2Valid = false;
                    Console.WriteLine("You entered an invalid number.");
                }

            }

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("This is now number 1: {0}, and number 2: {1}", num1, num2);
        }           
        /// <summary>
        /// Challenge 3: Order of Operation
        /// </summary>
        public void resultOfSpecifiedOperation()
        {
            /* Specified Operations
             * • -1 + 4 * 6 
               • ( 35+ 5 ) % 7 
               • 14 + -4 * 6 / 11 
               • 2 + 15 / 6 * 1 - 7 % 2
            * */

            //Order of Operation
            //https://www.tradingcode.net/csharp/operators/operator-precedence-associativity/
            //Grouping () Things in groups will be evaluated first.
            //Multiplication *
            //Division /
            //Remainder % (The % operator computes the remainder after dividing its first operand by its second. )
            //Addition +
            //Subtraction -
            Console.WriteLine(-1 + 4 * 6); //-1 +24 = 23
            Console.WriteLine((35 + 5) % 7); //40/7 - gives remainder 5
            Console.WriteLine(14 + -4 * 6 / 11); //14 - (24 / 11)   or 14 + (-24/11) which is 14 -2.
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);  //First 6*1 = 6.   Second 15/6 = 2  Third 7%2 = 1.  //2+2-1
        }
        public void sarahsResultOfOperationGame()
        {
                        char Answer;
            string Ans;

            Console.Write("Ready for a challenge? (y/n)?  ");
            Ans = Console.ReadLine();
            Answer = char.Parse(Ans);

            if(Answer == 'y') // first condition
            {
                Console.Write("\nGreat! See if you can solve these before the computer.\nEnter the answer for each problem.\n");
            }
            else // second condition
                Console.Write("\nToo bad. Try anyway. Enter the answer for each problem.");

            int prob1, prob2, prob3, prob4;
            int ans1, ans2, ans3, ans4;
            
            ans1 = (-1 + 4 * 6);
            ans2 = ((35 + 5) % 7);
            ans3 = (14 + -4 * 6 / 11);
            ans4 = (2 + 15 / 6 * 1 - 7 % 2);

            Console.Write("\nProblem 1: (-1 + 4 * 6) = "); // correct answer is 23
            prob1 = Convert.ToInt32(Console.ReadLine());
                if(prob1 == ans1)
                {
                    Console.WriteLine("That's correct!");
                }
                else
                    Console.WriteLine("Sorry, the correct answer is: " + ans1);

            Console.Write("\nProblem 2: ((35 + 5) % 7) = "); // correct answer is 5
            prob2 = Convert.ToInt32(Console.ReadLine()); 
                if(prob2 == ans2)
                {
                    Console.WriteLine("That's correct!");
                }
                else
                    Console.WriteLine("Actually, the answer is: " + ans2);
                
            Console.Write("\nProblem 3: (14 + -4 * 6 / 11) = "); // correct answer is 12
            prob3 = Convert.ToInt32(Console.ReadLine());
                if(prob3 == ans3)
                {
                    Console.WriteLine("You got it!");
                }
                else
                    Console.WriteLine("Not quite. The answer is: " + ans3);
                        
            Console.Write("\nProblem 4: (2 + 15 / 6 * 1 - 7 % 2) = "); // correct answer is 5
            prob4 = Convert.ToInt32(Console.ReadLine()); 
                if(prob4 == ans4)
                {
                    Console.WriteLine("BOOM!");
                }
                else
                    Console.WriteLine("No, sorry. The answer is: " + ans4);
                Console.ReadLine();
        }

        /// <summary>
        /// Print out the result of multiplying three numbers together given by the user.
        /// </summary>
        public void printOutputOfMultiplicationOfThreeNumbers_NoErrorHandling()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            num3 = int.Parse(Console.ReadLine());
            int result = num1 * num2 * num3;
            Console.WriteLine("The result of multiplying {0}x{1}x{2} = {3}", num1, num2, num3, result);

        }
        /// <summary>
        /// Print Output of two numbers being added/subtracted/multipled and divided
        /// </summary>
        public void printOutputAddingSubtractMultandDivideTwoNumbers()
        {
            int num1;
            int num2;
            Console.WriteLine("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int addTotal = num1 + num2;
            int subTotal = num1 - num2;
            int multTotal = num1 * num2;
            int divideTotal = num1 / num2;
            int modTotal = num1 % num2;
            Console.WriteLine("The added total of the two numbers entered is: " + addTotal);
            Console.WriteLine("The subtracted total of the two numbers entered is: " + subTotal);
            Console.WriteLine("The multiplied total of the two numbers entered is: " + multTotal);
            Console.WriteLine("The divided total of the two numbers entered is: " + divideTotal);
            Console.WriteLine("The Mod total of the two numbers entered is: " + modTotal);

            //Or you could write it this way to reduce the variables
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);

        }
        /// <summary>
        /// Print a single numbers multiplication table
        /// </summary>
        public void printANumbersMultiplicationTable()
        {
            Console.WriteLine("Please enter a number so we can generate its multiplcation table: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", number, i, number * 1);
            }

        }
        /// <summary>
        /// Taking four numbers and outputing the average
        /// </summary>
        public void fournumbersAverage()
        {
            int totalNumToAverage = 4;
            int addNumTogether = 0;
            int avg = 0;
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Enter the {0} of 4 numbers: ", i);
                addNumTogether += Convert.ToInt32(Console.ReadLine());
            }
            //Now average the numbers
            avg = addNumTogether / totalNumToAverage;
            Console.WriteLine("The total of the numbers you entered is: " + addNumTogether);
            Console.WriteLine("The average of these numbers are: " + avg);

            //Another way to do it
            int number1, number2, number3, number4;

            Console.Write("Enter the First number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the four number: ");
            number4 = Convert.ToInt32(Console.ReadLine());

            int result = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine("The average of {0} , {1} , {2} , {3} is: {4} ",
            number1, number2, number3, number4, result);

        }
        /// <summary>
        /// Performing more complex math functions on three numbers from the user.
        /// </summary>
        public void mathWithThreeNumbers()
        {
            Console.WriteLine("Enter the first number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The result of specified numbers {0}, {1} and {2}, (x+y)*z is: {3} ", x, y, z, ((x + y) * z));
            Console.WriteLine("The result of specified numbers {0}, {1} and {2}, x*y + y*z is: {3} ", x, y, z, ((x * y) + (y * z)));

        }
        /// <summary>
        /// Convert Temperatures
        /// </summary>
        public void calcualateDifferentTemperatures()
        {
            //Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
            Console.Write("Enter the amount of celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
        }

        public void GetCombinations_AdditionNoDuplicates()
        {
            Console.WriteLine("Enter a number: ");
            int usersNumber = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i<usersNumber; i++)
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
                if(checkMidPoint == i || checkMidPoint == (i+1))
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
                Console.WriteLine("Combination {0}: {1} + {2} = {3}", i, usersNumber -i, i, usersNumber);

            }
            #endregion

        }






    }

    
}
