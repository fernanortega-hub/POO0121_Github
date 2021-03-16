using System;

namespace program01
{
    class Program
    {
        static void Main(string[] args)
        {
           var a = 0;
           var b = 0;

           Console.WriteLine("Enter ´a´ value: ");
           a = Int32.Parse(Console.ReadLine());

           Console.WriteLine("Enter ´b´ value: ");
           b = Int32.Parse(Console.ReadLine());

           Console.WriteLine($"Adding the values of {a} + {b} give: "+ sum(a,b));
        }

        public static int sum (int a, int b)
        {
            return a+b;
        }
    }
}
