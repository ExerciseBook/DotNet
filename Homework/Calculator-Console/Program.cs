using System;

namespace Calculator_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, result = 0;
            Double.TryParse(Console.ReadLine(), out a);
            Double.TryParse(Console.ReadLine(), out b);

            char? oper;
            oper = Console.ReadLine()?.Trim()?[0];
            
            switch (oper) {
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
