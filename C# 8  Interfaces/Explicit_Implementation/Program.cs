using System;

namespace Explicit_Implementation
{
    interface i1
    {
        void show();
    }

    interface i2
    {
        void show();
    }

    class MyClass : i1, i2
    {
        void i1.show()
        {
            Console.WriteLine("This is a method of interface i1  !!");
        }

        void i2.show()
        {
            Console.WriteLine("This is a method of interface i2  !!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Explicit Implementation =>");


            i1 obj4 = new MyClass();
            obj4.show();
            i2 obj5 = new MyClass();
            obj5.show();
        }
    }
}