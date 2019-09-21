using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionControlClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Type first number: ");
            a = System.Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type second number: ");
            b = System.Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a} + {b} = {a + b}");

            Console.ReadKey();

        }
    }
}
