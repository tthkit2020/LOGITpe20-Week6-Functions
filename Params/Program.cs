using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamsSum(5, 5);
            DisplayString("100");
        }

        //write a function that takes in two numbers and displays
        //their sum as a result
        public static void ParamsSum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
        //write a function that takes in a string as a parameter
        //and displays it in the console
        public static void DisplayString(string someString)
        {
            Console.WriteLine(someString);
        }
    }
}
