using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thr = new Thread(worker_func);
            thr.Name = "Thread1";
            thr.IsBackground = true;
            thr.Start();
            Console.WriteLine("Main thread Running");
            Console.ReadKey();
        }
        static void worker_func()
        {
            Console.WriteLine("Thread {0} started", Thread.CurrentThread.Name);
            Thread.Sleep(2000);
            Console.WriteLine("Thread {0} completed", Thread.CurrentThread.Name);
        }
    }
}
