namespace Multi_Cast_Delegates
{
    public delegate void Calculations(int a, int b);
    class Program
    {
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Addition result is : {result}");
        }
        public static void Substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine($"Substraction result is : {result}");
        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine($"Multiplication result is : {result}");
        }
        public static void Divison(int a, int b)
        {
            int result = a / b;
            Console.WriteLine($"Divison result is : {result}");
        }

        static void Main(string[] args)
        {
            Calculations obj = new Calculations(Addition);

            //Multicasting the delegate

            obj += Substraction;
            obj += Multiplication;
            obj += Divison;

            //Invoking
            obj.Invoke(150,10);
        }
    }
}