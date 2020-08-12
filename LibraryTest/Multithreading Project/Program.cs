using System;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GUESS THE NUMBER!");
            Random random = new Random();
            int number = random.Next(1, 11);

            var countdown = Tasks.countDown();

            Tasks idk = new Tasks();
            while (idk.loop)
            {
                int guessedNumber = int.Parse(Console.ReadLine());
                var guessNumber = idk.guessRandomNumber(guessedNumber, number);

                Task.WaitAny(guessNumber, countdown);
            }
        }
    }
}