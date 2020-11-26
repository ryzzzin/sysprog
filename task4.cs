using System;
using System.Threading;
using System.Diagnostics;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            foreach(Process process in Process.GetProcesses())
            {
                Console.WriteLine(process.Id + " " + process.ProcessName);
            }
            */
            
            var proc = Process.Start("notepad"); //or another process like cmd etc
            Console.WriteLine("subprocess pid: " + proc.Id);
            Thread.Sleep(3000);
            Console.WriteLine("killing subprocess...");
            proc.Kill();
            
        }
    }
}
