using System;

namespace Calculator_Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double a, b, result = 0;
            double.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out b);

            char? oper;
            oper = Console.ReadLine()?.Trim()?[0];

            switch (oper)
            {
                case '+':
                {
                    result = a + b;
                    break;
                }
                case '-':
                {
                    result = a - b;
                    break;
                }
                case '*':
                {
                    result = a * b;
                    break;
                }
                case '/':
                {
                    result = a / b;
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}