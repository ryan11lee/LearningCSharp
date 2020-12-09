using System;

namespace DataTypesandVariables
{
     class Program
    { 
        private static void Main0(string[] args)
        {
            int num1 = 13;
            int num2 = 25;
            // int num3;
            int sum = num1 + num2;
            double d1 = 3.5;
            double d2 = 1.337;
            double sumDouble = d1 + d2;
            string equation = $"{num1} + {num2} = {sum}";
            string equation2 = $"{d1} + {d2} = {sumDouble}";
            // num3 = 13;

            float f1 = 3.5f;
            float f2 = 1.4567f;

            float divFloat = f1 / f2;
            string equation3 = $"{f1} / {f2} = {divFloat}";
            Console.WriteLine(equation);
            Console.WriteLine(equation2);
            Console.WriteLine(equation3);

        }
    }
}

