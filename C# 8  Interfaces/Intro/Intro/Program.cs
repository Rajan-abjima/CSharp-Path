namespace Intro
{   
    interface IEmployees
    {
        void show();
    }

    class PartTimeEmployees : IEmployees
    {
        public void show() 
        {
            Console.WriteLine("This is method of IEmployee interface.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployees pte = new PartTimeEmployees();
            pte.show();
        }
    }
}