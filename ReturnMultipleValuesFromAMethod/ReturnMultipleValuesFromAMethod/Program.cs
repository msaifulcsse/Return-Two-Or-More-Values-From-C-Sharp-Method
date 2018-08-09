using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnMultipleValuesFromAMethod
{
    public class Program
    {
        //Method for returning multiple values using OUT keyword
        static int DividedResultUsingOutKeyword(int numberOne, int numberTwo, out int remainder)
        {
            int quotient = 0;
            if (numberOne >= numberTwo)
            {
                remainder = numberOne % numberTwo;
                quotient = numberOne / numberTwo;
            }
            else
            {
                remainder = numberTwo % numberOne;
                quotient = numberTwo / numberOne;
            }

            return quotient;
        }

        static void Main(string[] args)
        {
            //Calling method & get result by usign OUT keyword;
            int remainder = 0;
            int quotient = DividedResultUsingOutKeyword(7, 2, out remainder);
            Console.WriteLine("The Quotient Value Is: {0} \nThe Remainder Value Is: {1}", quotient, remainder);
            Console.ReadKey();
        }
    }
}
