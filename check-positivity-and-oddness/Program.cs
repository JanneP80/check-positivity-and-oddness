using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_positivity_and_oddness
{
    class Program
    {
        static void Main(string[] args)
        {
            // checs if number is odd or even
            int inputnumber = 0;
            string message = string.Empty;
            Console.Write("This program checks if typed number is odd/even or zero, \nand negative/positive or zero. Type number: ");
            bool result = int.TryParse(Console.ReadLine(), out inputnumber);
            if (!result) // incorrect input
            {
                message = "Input is NOT a number.";
            }

            else if (inputnumber % 2 == 0) //divided, true, is even
            {
                
                if (inputnumber == 0)
                {
                    message = string.Format("You type number zero {0},", inputnumber);
                }
                else if (inputnumber < 0)
                {
                    message = string.Format("You typed number {0} and it is negative,", inputnumber);
                }
                else
                {
                    message = string.Format("You typed number {0} and it is positive,", inputnumber);
                }
                Console.WriteLine(message);

                message = string.Format("and it is even.", inputnumber);
            }
            else // else odd
            {
                if (inputnumber == 0)
                {
                    message = string.Format("You type number zero {0},", inputnumber);
                }
                else if (inputnumber < 0)
                {
                    message = string.Format("You typed number {0} and it is negative,", inputnumber);
                }
                else
                {
                    message = string.Format("You typed number {0} and it is positive,", inputnumber);
                }
                Console.WriteLine(message);

                message = string.Format("and it is odd.", inputnumber);
            }


            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
