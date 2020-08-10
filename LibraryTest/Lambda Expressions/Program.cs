using System;
using Overloading;
namespace Lambda_Expressions
{
    class Program
    {
        delegate int SquareDel(int i);
        delegate float FloatDel(float float1, float float2, float float3);
        delegate string emptyDel();
        static void Main(string[] args)
        {
            SquareDel square = x => x * 2;
            Console.WriteLine(square(5));

            FloatDel flud = (x, y, z) => x + y + z;
            Console.WriteLine(flud(9.1f, 19.4f, 7.4f));

            emptyDel empty = () => "Hello world";
            Console.WriteLine(empty());
        }
    }
}
