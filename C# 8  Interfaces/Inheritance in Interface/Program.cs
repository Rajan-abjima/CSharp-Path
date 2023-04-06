using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Inheritance_in_Interface
{   
    interface i1
    {
        void print();
    }
    interface i2
    {
        void print1();
    }
    interface i3 : i1, i2
    {
        void print2();
    }


    class Program : i3
    {
        public void print()
        {
            Console.WriteLine("This is a method of Interface 1");
        }
        public void print1()
        {
            Console.WriteLine("This is a method of Interface 2");
        }
        public void print2()
        {
            Console.WriteLine("This is a method of Interface 3");
        }

        static void Main(string[] args)
        {
            //Program p = new Program();
            //p.print();
            //p.print1();
            //p.print2();

            i1 myinterface = new Program();
            myinterface.print();

        }
    }
}