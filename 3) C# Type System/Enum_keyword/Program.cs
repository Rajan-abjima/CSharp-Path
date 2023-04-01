using System;
namespace EnumerationExample
{

    enum year
    {

        // items of the enum
        January,
        February,
        March,
        April,
        May,
        June

    }

    class Program
    {

        static void Main(string[] args)
        {

            // Printing out the integer values of the items
            Console.WriteLine("The value of January in year " + "enum is " + (int)year.January);
            Console.WriteLine("The value of February in year " + "enum is " + (int)year.February);
            Console.WriteLine("The value of March in year " + "enum is " + (int)year.March);
            Console.WriteLine("The value of April in year " + "enum is " + (int)year.April);
            Console.WriteLine("The value of May in year " + "enum is " + (int)year.May);
            Console.WriteLine("The value of June in year " + "enum is " + (int)year.June);
        }
    }
}