using System;
using Overloading;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            math yolo = new math();

            Console.WriteLine(yolo.division(4, 2));
            Console.WriteLine(yolo.division(8.8f, 2.2f));
            Console.WriteLine(yolo.additive("2", "4"));
        }
    }
}
