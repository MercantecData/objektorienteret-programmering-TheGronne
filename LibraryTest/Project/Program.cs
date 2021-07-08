using System;
using LibraryTest;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Job developer = new Job("Developer", "Leader", "GoHomeStreet", 14000, 36);
            Person jesper = new Person("Jesper", 20, "HomeStreet", 161200, 185, 100, developer);
            People developers = new People();
            developers.addToList(jesper);

            Console.WriteLine(developers.people[0].name);
        }
    }
}