using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
//Exercise 75
//Written by: Muna Shabab
//Date:10-10-2020

namespace _75_Muna_Shabab
{
    class Program
    {
        static void Main(string[] args)
        {
            //explain the application 
            Console.WriteLine("This application accepts two integers and raises the first to the power "
                +" of the second using a recursive method");
            //prompt the user for input and validate
            Console.WriteLine("Enter an integer greater than or equal to 1 for the base:");
            string input = Console.ReadLine();
            int pbase = GetValidInteger(input);

            Console.WriteLine("Enter an integer greater than or equal 1 for the exponent:");
            input = Console.ReadLine();
            int expNum = GetValidInteger(input);

            //declare a variable to hold the results and assing it the value reurned from the function
            long result = Power(pbase, expNum);

            //display the results
            if (result == 0)
            {
                Console.WriteLine("The number is too large to be contained in an int");
            }
            else
            {
                Console.WriteLine(pbase + " raised to the power of " + expNum + " is " + result);
            }
            
            Console.ReadLine();

        }
        public static int GetValidInteger(string input)
        {
            int num;
            while ((!(int.TryParse(input, out num))) || num <1)
            {

                Console.WriteLine(input + " is not a valid  input");
                Console.WriteLine("please enter an integer greater than or equal to 1 :");
                input = Console.ReadLine();
            }

            return num;
        }
        public static long Power(int pbaseIn, int exponentIn)
        {
            long powResult=0;
            try
            {
                checked
                {
                    // if the base case is reached
                    if (exponentIn == 1)
                    {
                        return pbaseIn;
                    }

                    //call back the function 
                    else
                    {
                       powResult= pbaseIn * (Power(pbaseIn, exponentIn - 1));
                        return powResult;

                    }

                }

            }
            catch (System.OverflowException e)
            {
                // The following line displays information about the error.
                Console.WriteLine("CHECKED and CAUGHT:  " + e.ToString());
            }
            // The value of z is still 0.

            return powResult;

        }
    }
}
