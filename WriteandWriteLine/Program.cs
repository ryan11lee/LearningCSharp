using System;

namespace WriteandWriteLine
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Hellow Welcome");
        Console.Write("Hello");
        Console.Write("Welcome");
        Console.WriteLine("Enter a string and press enter");
        string readInput = Console.ReadLine();
        Console.WriteLine("You have entered {0}",readInput);

        Console.Write("Enter a strong and press enter");
        int asciiValue = Console.Read();
        Console.WriteLine("ASCII value is {0}", asciiValue);
        Console.ReadKey();
        }
    }
}
