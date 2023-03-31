using System;

namespace Calculator_Demo
{
    class Program
    {
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Addition Result is {result}");
        }

        public static void Substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine($"Addition Result is {result}");
        }

        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine($"Multiplication Result is {result}");
        }

        public static void Divison(int a, int b)
        {
            int result = a / b;
            Console.WriteLine($"Divison Result is {result}");
        }
        static void Main(string[] args)
        {
            //Asking user for two numbers
            //First number
            Console.WriteLine("Please enter first number:");
            int num1 = int.Parse(Console.ReadLine());
            //second number
            Console.WriteLine("Please enter first number:");
            int num2 = int.Parse(Console.ReadLine());
            //Operator selection
            Console.WriteLine("Please enter operator (+, -, *, /):");
            string op = Console.ReadLine();

            if (op == "+")
            {
                Program.Addition(num1, num2);
            }
            else if (op == "-")
            {
                Program.Substraction(num1, num2);
            }
            else if (op == "*")
            {
                Program.Multiplication(num1, num2);
            }
            else if (op == "/")
            {
                Program.Divison(num1, num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
        }

    }
}