using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadStartSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*ThreadStart Delegate App *\n");
            Console.Write("Do you want [1] or [2] threads? ");
            string threadCount = Console.ReadLine();

            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Primary";

            Console.WriteLine("-> {0} is executing Main()",
            Thread.CurrentThread.Name);

            Printer p = new Printer();

            switch (threadCount)
            {
                case "2":
                    Thread backgroundThread = new Thread(new ThreadStart(p.PrintNumbers));
                    backgroundThread.Name = "Secondary";
                    backgroundThread.Start();
                    break;
                case "1":
                    p.PrintNumbers();
                    break;
                default:
                    Console.WriteLine("I dont know what...you get 1 thread.");
                    goto case "1";
            }
            Console.WriteLine("Hello this from main!");
        }
    }
}
