namespace Multiple_Delegates
{
    public delegate void Show_Delegates();
    public delegate void Calculations(int num);
    class Program
    {
        public static void Show()
        {
            Console.WriteLine("This is a show method !!");
        }
        public static void Square(int num)
        {
            int square = num * num;
            Console.WriteLine($"Square of {num} is {square}");
        }
        public static void Cube(int num)
        {
            int cube = num * num * num;
            Console.WriteLine($"Cube of {num} is {cube}");
        }

        static void Main(string[] args)
        {
            Show_Delegates obj = new Show_Delegates(Show);
            obj.Invoke();

            Console.WriteLine();

            Calculations obj1 = new Calculations(Square);
            obj1.Invoke(5);
            
            Calculations obj2 = new Calculations(Cube);
            obj2.Invoke(3);


        }
    }
}