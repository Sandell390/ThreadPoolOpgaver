using System;
using System.Threading;

namespace Øvelse_0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object is being created
            ThreadPoolDemo tpd = new ThreadPoolDemo();

            for (int i = 0; i < 2; i++)
            {
                //Task1 is being executed on another thread in the threadpool
                ThreadPool.QueueUserWorkItem(tpd.task1);

                //Task2 is being executed on another thread in the threadpool
                ThreadPool.QueueUserWorkItem(tpd.task2);
            }

            Console.Read();
        }
    }

    class ThreadPoolDemo
    {
        public void task1(object obj)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Task 1 is being executed");
            }
        }

        public void task2(object obj)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Task 2 is being executed");
            }
        }

    }
}
