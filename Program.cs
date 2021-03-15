using System;

namespace program01
{
    class Program
    {
        static void Main(string[] args)
        {
           var a = 0;
           var b = 0;

           Console.WriteLine("Enter a value: ");
           a = Int32.Parse(Console.ReadLine());

           Console.WriteLine("Enter anothere value: ");
           b = Int32.Parse(Console.ReadLine());

           Console.WriteLine($"Adding the values of {a} and {b} give: ");

           
        }
    }
}
