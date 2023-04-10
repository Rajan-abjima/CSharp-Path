namespace Generic_Class
{
    internal class Program
    {   class Example<T>
        {
            T box;
            public T Box
            {
                set 
                { 
                    this.box = value;
                }
                get 
                { 
                    return this.box;
                }
            }

            //public Example(T b)
            //{ 
            //    this.box = b;
            //}

            //public T getBox()
            //{
            //    return this.box;
            //}

        }
        static void Main(string[] args)
        {
            //Example<int> e = new Example<int>(199);
            //Console.WriteLine(e.getBox());
            
            //Example<string> e1 = new Example<string>("Hello");
            //Console.WriteLine(e1.getBox());

            Example<int> e = new Example<int>(); 
            Example<string> e1 = new Example<string>();
            e.Box = 20;
            e1.Box = "Hello";
            Console.WriteLine(e.Box);
            Console.WriteLine(e1.Box);
        }
    }
}