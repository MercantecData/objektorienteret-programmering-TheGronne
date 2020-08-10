using System;
using Overloading;

namespace Delegate4
{
    class Program
    {
        delegate void emptyDel();
        delegate float floatDel();
        delegate void fullDel(string str, int i, float fl);
        static void Main(string[] args)
        {
            emptyDel empty = new emptyDel(opgave1);
            empty();
            floatDel floaty = new floatDel(opgave2);
            Console.WriteLine(floaty());
            fullDel fully = new fullDel(opgave3);
            fully("Grønne", 19, 185f);
        }

        static void opgave1()
        {
            Console.WriteLine("Yo");
        }

        static float opgave2()
        {
            float lmao = 2.4f;
            return lmao;
        }

        static void opgave3(string name, int age, float height)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height);
        }
    }
}
