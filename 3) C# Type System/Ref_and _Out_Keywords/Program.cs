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

        static void Main(string[] args)
        {
            //For PASS BY VALUE
            int value = 5;
            PassByValue(value);
            Console.WriteLine(value);

            //For PASS BY REF
            int valueee = 5;
            PassByRef(ref valueee);
            Console.WriteLine(valueee);
        }
    }
}