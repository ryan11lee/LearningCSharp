using System;

namespace DataTypesandVariables
{
    class StringConcat
    {static void Main(string[] args)
        {
        string myName ="Ryan";
        string part1 = "My name is ";
        string message = part1 + myName;

        string upperMessage = message.ToUpper();

        string test = "I am testing out Lower Case Methods";

        string lowerMessage = test.ToLower();
        Console.WriteLine(upperMessage);
        Console.WriteLine(lowerMessage);
        Console.Read();
        }
    }
}