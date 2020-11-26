using System;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch mywatch = new Stopwatch();
            Console.WriteLine("Thread Pool Execution");
            mywatch.Start();
            ProcessWithThreadPoolMethod();
            mywatch.Stop();
            Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is: " + mywatch.ElapsedTicks.ToString());
            mywatch.Reset();
            Console.WriteLine("Thread Execution");
            mywatch.Start();
            ProcessWithThreadMethod();
            mywatch.Stop();
            Console.WriteLine("Time consumed by ProcessWithThreadMethod is: " + mywatch.ElapsedTicks.ToString());
        }
        static void ProcessWithThreadPoolMethod()
        {
            for(int i = 0; i <= 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(Process));
            }
        }
        static void ProcessWithThreadMethod()
        {
            for(int i = 0; i <= 10; i++)
            {
                Thread obj = new Thread(Process);
                obj.Start();
            }
        }
        static void Process(object callback) { }
    }
}
