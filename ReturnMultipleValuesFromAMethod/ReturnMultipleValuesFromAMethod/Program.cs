using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnMultipleValuesFromAMethod
{
    public class Program
    {
        #region "Method for returning multiple values using OUT keyword"
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
        #endregion

        #region "Method for returning multiple values using REF keyword"
        static void DividedResultUsingRefKeyword(int numberOne, int numberTwo, ref int quotient, ref int remainder)
        {
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
        }
        #endregion

        #region "Declared a struct & a Method for returning multiple values using structures"
        //Structure declaration
        struct DividedInfo
        {
            public int Quotient { get; set; }
            public int Remainder { get; set; }
        }

        //Method for returning multiple values using Structures
        static DividedInfo DividedResultUsingStructure(int numberOne, int numberTwo)
        {
            DividedInfo dInfo = new DividedInfo();

            if (numberOne >= numberTwo)
            {
                dInfo.Remainder = numberOne % numberTwo;
                dInfo.Quotient = numberOne / numberTwo;
            }
            else
            {
                dInfo.Remainder = numberTwo % numberOne;
                dInfo.Quotient = numberTwo / numberOne;
            }

            return dInfo;
        }
        #endregion

        #region "Declared a class & a Method for returning multiple values using classes"
        //CLass declaration
        class ClsDividedInfo
        {
            public int Quotient { get; set; }
            public int Remainder { get; set; }
        }

        //Method for returning multiple values using Structures
        static ClsDividedInfo DividedResultUsingClass(int numberOne, int numberTwo)
        {
            ClsDividedInfo dInfo = new ClsDividedInfo();

            if (numberOne >= numberTwo)
            {
                dInfo.Remainder = numberOne % numberTwo;
                dInfo.Quotient = numberOne / numberTwo;
            }
            else
            {
                dInfo.Remainder = numberTwo % numberOne;
                dInfo.Quotient = numberTwo / numberOne;
            }

            return dInfo;
        }
        #endregion

        #region "Method for returning multiple values by passing a object of a class as an argument"

        //Method for returning multiple values by passing a object as an argument
        static void DividedResultByPassingObject(int numberOne, int numberTwo, ClsDividedInfo clsDividedInfo)
        {
            if (numberOne >= numberTwo)
            {
                clsDividedInfo.Remainder = numberOne % numberTwo;
                clsDividedInfo.Quotient = numberOne / numberTwo;
            }
            else
            {
                clsDividedInfo.Remainder = numberTwo % numberOne;
                clsDividedInfo.Quotient = numberTwo / numberOne;
            }
        }
        #endregion

        #region "Method for returning multiple values using KeyValue Pair"
        static KeyValuePair<int, int> DividedResultUsingKeyValuePair(int numberOne, int numberTwo)
        {
            var keyValuePair = new KeyValuePair<int, int>();

            if (numberOne >= numberTwo)
            {
                keyValuePair = new KeyValuePair<int, int>(numberOne / numberTwo, numberOne % numberTwo);
            }
            else
            {
                keyValuePair = new KeyValuePair<int, int>(numberTwo / numberOne, numberTwo % numberOne);
            }
            return keyValuePair;
        }
        #endregion

        static void Main(string[] args)
        {
            //Calling method & get result by usign OUT keyword;
            int remainderUsingOut = 0;
            int quotientUsingOut = DividedResultUsingOutKeyword(7, 2, out remainderUsingOut);
            Console.WriteLine("1. Using out keyword:\n--------------------\nThe quotient value is: {0} \nThe remainder value is: {1}", quotientUsingOut, remainderUsingOut + "\n--------------------");

            //Calling method & get result by usign REF keyword;
            int quotient = 0, remainder = 0;
            DividedResultUsingRefKeyword(7, 2, ref quotient, ref remainder);
            Console.WriteLine("2. Using ref keyword:\n--------------------\nThe quotient value is: {0} \nThe remainder value is: {1}", quotient, remainder + "\n-------------------");

            //Calling method & get result by usign Structure;
            DividedInfo structDInfo = DividedResultUsingStructure(7, 2);
            Console.WriteLine("3. Using structure:\n-------------------\nThe quotient value is: {0} \nThe remainder value is: {1}", structDInfo.Quotient, structDInfo.Remainder + "\n---------------");

            //Calling method & get result by usign Class;
            ClsDividedInfo dInfo = DividedResultUsingClass(7, 2);
            Console.WriteLine("4. Using class:\n---------------\nThe quotient value is: {0} \nThe remainder value is: {1}", dInfo.Quotient, dInfo.Remainder + "\n-------------------------------------");

            //Calling method & get result by passing a object of a Class as an argument;
            ClsDividedInfo clsDivideInfo = new ClsDividedInfo();
            DividedResultByPassingObject(7, 2, clsDivideInfo);
            Console.WriteLine("5. By passing a object as an argument:\n-------------------------------------\nThe quotient value is: {0} \nThe remainder value is: {1}", clsDivideInfo.Quotient, clsDivideInfo.Remainder + "\n-----------------------");

            //Calling method & get result using KeyValue Pair;
            var dividedResult = DividedResultUsingKeyValuePair(7, 2);
            Console.WriteLine("6. Using KeyValue Pair:\n-----------------------\nThe quotient value is: {0} \nThe remainder value is: {1}", dividedResult.Key, dividedResult.Value);

            Console.ReadKey();
        }
    }
}
