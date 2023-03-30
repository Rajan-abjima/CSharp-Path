using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeinTests;

namespace Project
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            GreeterService greeterService = new GreeterService();
            Console.WriteLine(greeterService.GenerateGreetText());
        }
    }
}
