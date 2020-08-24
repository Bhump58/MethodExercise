using System;
using System.Runtime.InteropServices;

namespace MethodExercise
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            var userColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            var userAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            var userBand = Console.ReadLine();

            MyAdlib(userName, userColor, userAnimal, userBand);
            Console.WriteLine("*****************************");
            Console.WriteLine("*****************************");
            Console.WriteLine("*****************************");

            Console.WriteLine(add(1, 1, 1, 1, 1));
            


        }

        public static void MyAdlib(string userName, string userColor, string userAnimal, string userBand)
        {
            Console.WriteLine($"Hello {userName}, my name is program. I see that your favorite color is {userColor}, favorite animal is, {userAnimal}, " +
                $"and favorite band is named {userBand}. That's pretty cool.");
        }

        public static int add(int a, int b)
        {
            return a + b;
        }

        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }

        public static int add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

        public static int add(int a, int b, int c, int d, int e)
        {
            return a + b + c + d + e;
        }
    }
}
