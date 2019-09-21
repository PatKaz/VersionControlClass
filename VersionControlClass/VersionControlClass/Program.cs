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

            bool quit = false;
            while(!quit)
            {
                Console.Clear();
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Substract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("0. Quit");

                switch(System.Convert.ToInt32(Console.ReadLine()))
                { 
                    case 1:
                        Addition();
                        continue;
                    case 2:
                        Substract();
                        break;
                    case 3:
                        Multiply();
                        break;
                    case 4:
                        Divide();
                        break;
                    case 0:
                        quit = true;
                        break;
                }

            }

        }

        private static void Addition()
        {
            int a;
            int b;
            Console.Clear();
            Console.WriteLine("Type first number: ");
            a = System.Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type second number: ");
            b = System.Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine("Press anything to continue");

            Console.ReadKey();
        }

        private static void Substract()
        {
            int a;
            int b;
            Console.Clear();
            Console.WriteLine("Type first number: ");
            a = System.Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type second number: ");
            b = System.Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a} + {b} = {a - b}");
            Console.WriteLine("Press anything to continue");

            Console.ReadKey();
        }
        private static void Multiply()
        {
            int a;
            int b;
            Console.Clear();
            Console.WriteLine("Type first number: ");
            a = System.Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type second number: ");
            b = System.Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a} + {b} = {a * b}");
            Console.WriteLine("Press anything to continue");

            Console.ReadKey();
        }

        private static void Divide()
        {
            float a;
            float b;
            Console.Clear();
            Console.WriteLine("Type first number: ");
            a = System.Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type second number: ");
            b = System.Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a} + {b} = {a / b}");
            Console.WriteLine("Press anything to continue");

            Console.ReadKey();
        }



    }
}
