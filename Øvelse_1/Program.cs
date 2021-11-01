using System;
using System.Diagnostics;
using System.Threading;

namespace Øvelse_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch mywatch = new Stopwatch();
            
            Console.WriteLine("Thread Pool Execution");
            mywatch.Start();
            
            ProcessWithThreadPoolMethod(); // 13 ms
            
            mywatch.Stop();

            Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is : " + mywatch.ElapsedMilliseconds.ToString());

            mywatch.Reset();
            
            Console.WriteLine("Thread Execution");
            mywatch.Start();
            
            ProcessWithThreadMethod(); // 3000 ms
            
            mywatch.Stop();
            
            Console.WriteLine("Time consumed by ProcessWithThreadMethod is : " + mywatch.ElapsedMilliseconds.ToString());

        }

        static void ProcessWithThreadMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread obj = new Thread(Process);
                obj.Start();
            }
        }

        static void ProcessWithThreadPoolMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                ThreadPool.QueueUserWorkItem(Process);
            }
        }


        static void Process(object obj)
        {
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 100000; j++)
                {
                    int _;
                }
            }
        }



    }
}
