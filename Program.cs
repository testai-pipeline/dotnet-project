using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Welcome to .NET Programming!");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}