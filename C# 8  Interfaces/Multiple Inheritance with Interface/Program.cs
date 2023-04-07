using System.Collections.Concurrent;

namespace Multiple_Inheritance_with_Interface
{   
    class Person
    {
        public void show()
        {
            Console.WriteLine("This is method of Person class");
        }
    }
    interface Employee
    {
        void show();
    }
    interface Employee1
    {
        void show();
    }

    class Teacher : Person, Employee, Employee1
    {
        void Employee.show()
        {
            Console.WriteLine("This is a method of Employee Interface");
        }
        void Employee1.show()
        {
            Console.WriteLine("This is a method of Employee 1 Interface");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            t.show();
            Employee e = new Teacher();
            e.show();
            Employee1 e1 = new Teacher();
            e1.show();
            

        }
    }
}