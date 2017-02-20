using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDrills_ConsoleApp.BasicConsoleDrills
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
        /// Challenge 4
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







    }
}
