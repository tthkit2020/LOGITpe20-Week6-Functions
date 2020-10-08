using System;

namespace Week6Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //call a function
            HelloUser();
            Sum();
        }

        public static void HelloUser() //create a function
        {
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}");
        }

        public static void Sum()
        {
            Console.WriteLine("Enter the first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int b = Int32.Parse(Console.ReadLine());

            int result = a + b;
            Console.WriteLine(result);
        }

    }
}
