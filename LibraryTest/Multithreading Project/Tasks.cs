using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading_Project
{
    public class Tasks
    {
        public bool loop = true;
        public static Task countDown()
        {
            Task task = new Task(() =>
            {
                for (int i = 10; i > 0; i -= 1)
                {
                    Task.Delay(1 * 1000).Wait();
                    Console.WriteLine(i);
                }
            });
            task.Start();
            return task;
        }

        public Task guessRandomNumber(int guessNUmber, int realNumber)
        {
            Task task = new Task(() =>
            {
                if (guessNUmber == realNumber)
                {
                    Console.WriteLine("YOU WON!");
                    loop = false;
                }
                else
                {
                    
                }
            });
            task.Start();
            return task;
        }
    }
}
