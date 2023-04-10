namespace Delegates
{
    public delegate void Calculations(int a, int b);
    class Program
    {   public static void Addition (int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Addition result is : {result}");
        }
        public static void Substraction (int a, int b)
        {
            int result = a - b;
            Console.WriteLine($"Substraction result is : {result}");
        }
        public static void Multiplication (int a, int b)
        {
            int result = a * b;
            Console.WriteLine($"Multiplication result is : {result}");
        }
        public static void Divison (int a, int b)
        {
            int result = a / b;
            Console.WriteLine($"Divison result is : {result}");
        }

        static void Main(string[] args)
        {
            Calculations obj = new Calculations(Program.Addition);
            obj.Invoke(20, 10);

            Calculations obj1 = new Calculations(Program.Substraction);
            obj1(25, 15);
            Calculations obj2 = new Calculations(Program.Multiplication);
            obj2(10, 5);
            Calculations obj3 = new Calculations(Program.Divison);
            obj3(25, 5);

        }
    }
}