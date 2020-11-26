using System;
using System.Threading;

namespace lesson
{
    public class worker
    {
        public void worker_main_method()
        {
            Thread.Sleep(2000);
            Console.WriteLine("new thread state: " + Thread.CurrentThread.ThreadState);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thread curr_thread = Thread.CurrentThread;
            curr_thread.Name = "main_thread";
            Console.WriteLine("thread name: " + curr_thread.Name);
            Console.WriteLine("thread aliveness: " + curr_thread.IsAlive);
            //
            Console.WriteLine("thread prior: " + curr_thread.Priority);
            curr_thread.Priority = ThreadPriority.Highest;
            Console.WriteLine("thread prior: " + curr_thread.Priority);
            //
            Console.WriteLine("thread state: " + curr_thread.ThreadState);
            Console.WriteLine("thread domain: " + Thread.GetDomain().FriendlyName);
            //
            worker obj = new worker();
            Thread thr = new Thread(new ThreadStart(obj.worker_main_method));
            Console.WriteLine("thread state: " + thr.ThreadState);
            thr.Start();
            Thread.Sleep(100);
            Console.WriteLine("new thread state: " + thr.ThreadState);
            while (thr.IsAlive)
            {
                Thread.Sleep(1000);
                Console.WriteLine("worker is still alive");
            }
            Console.WriteLine("new thread aliveness: " + thr.IsAlive);
        }
    }
}
