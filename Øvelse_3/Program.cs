using System;
using System.Threading;

namespace Øvelse_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 0; i < 8; i++)
            {
                ThreadPool.QueueUserWorkItem(printer);

                
            }

            for (int i = 0; i < 4; i++)
            {
                ThreadPool.QueueUserWorkItem(printer2);
            }

            Console.Read();
        }

        static void printer(object obj)
        {
            
            for (int i = 0; i < 1000; i++)
            {
                int _;
            }

            Thread.CurrentThread.Priority = ThreadPriority.Lowest;
            Thread.CurrentThread.IsBackground = false;
            
            //Thread.CurrentThread.Suspend(); 
            //Thread.CurrentThread.Abort();
            Console.WriteLine($"ID: {Thread.CurrentThread.ManagedThreadId} | Alive: {Thread.CurrentThread.IsAlive} | Background: {Thread.CurrentThread.IsBackground} | ThreadPriority {Thread.CurrentThread.Priority}");
        }
        static void printer2(object obj)
        {
            for (int i = 0; i < 1000; i++)
            {
                int _;
            }

            Thread.CurrentThread.Priority = ThreadPriority.Highest;
            Console.WriteLine($"ID: {Thread.CurrentThread.ManagedThreadId} | Alive: {Thread.CurrentThread.IsAlive} | Background: {Thread.CurrentThread.IsBackground} | ThreadPriority {Thread.CurrentThread.Priority}");
        }
    }
}
