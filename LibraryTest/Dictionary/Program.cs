using System;
using LibraryTest;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionaries dics = new Dictionaries();
            dics.words.Add("NO", 1);
            dics.words.Add("YES", 2);
            dics.words.Add("WHY", 3);
            dics.words.Add("WHO", 4);
            dics.words.Add("WHERE", 5);
            dics.words.Add("WHAT", 6);
            dics.words.Add("WHATEVER", 7);
            dics.words.Add("Skrrt", 8);
            dics.words.Add("sdhsj", 9);
            dics.words.Add("idk", 10);

            Dictionaries buts = new Dictionaries();
            buts.bools.Add(2.4f, true);
            buts.bools.Add(1.2f, true);
            buts.bools.Add(0.1f, false);
            buts.bools.Add(0.001f, true);
            buts.bools.Add(101.1f, true);
            buts.bools.Add(7.1f, false);
            buts.bools.Add(0.4f, false);
            buts.bools.Add(1.5f, false);
            buts.bools.Add(9.8f, false);
            buts.bools.Add(7.5f, true);

            float userInput = float.Parse(Console.ReadLine());

            Console.WriteLine(buts.bools[userInput].ToString());
        }
    }
}