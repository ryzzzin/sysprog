using System;
using System.Threading;
using System.Diagnostics;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Process main_proc = Process.GetCurrentProcess();
            Console.WriteLine("handle: " + main_proc.Handle);
            Console.WriteLine("id: " + main_proc.Id);
            Console.WriteLine("name: " + main_proc.ProcessName);
            Console.WriteLine("start time: " + main_proc.StartTime);
            Thread.Sleep(2000);
            foreach(var process in Process.GetProcesses())
            {
                Console.WriteLine(process.ProcessName + " - " + process.Id);
            }
            ProcessStartInfo proc_info = new ProcessStartInfo();
            proc_info.FileName = "notepad";
            proc_info.Arguments = "";
            var proc = Process.Start(proc_info);
            Thread.Sleep(3000);
            proc.Kill();
        }
    }
}
