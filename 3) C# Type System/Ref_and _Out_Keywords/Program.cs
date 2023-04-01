namespace Ref_and__Out_Keywords
{
    class Program
    {   
        //PASS BY VALUE
        public static void PassByValue(int a)
        {
            a = a + 10;
            Console.WriteLine($"value of 'a' is {a}");
        }
        
        //PASS BY REF
        public static void PassByRef(ref int b)
        {
            b = b + 10;
            Console.WriteLine($"value of 'b' is {b}");
        }
        //PASS BY OUT
        public static void PassByOut(out int c)
        {
            c = 20;
            Console.WriteLine($"value of 'c' is {c}");
        }

        static void Main(string[] args)
        {
            //For PASS BY VALUE
            int value = 5;
            PassByValue(value);
            Console.WriteLine(value);

            //For PASS BY REF
            int valuee = 5;
            PassByRef(ref valuee);
            Console.WriteLine(valuee);

            //For PASS BY OUT
            int valueee;
            PassByOut(out valueee);
            Console.WriteLine(valueee);
        }
    }
}