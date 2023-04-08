namespace GENERICS_METHODS
{
    class Example
    {
        public static void showArray<T>(T[] arr) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[3];
            Numbers[0] = 11;
            Numbers[1] = 22;
            Numbers[2] = 33;

            
            string[] Names= { "Aman", "Rahul", "Amir" };
            Double[] Points = { 2.6, 4.3, 2, 4 };
            
            Example.showArray(Numbers);
            Example.showArray(Names);
            Example.showArray(Points);
        }
    }
}