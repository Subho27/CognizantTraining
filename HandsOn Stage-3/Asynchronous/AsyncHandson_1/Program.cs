using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONTROL");
            Method1().Wait();
            //Console.WriteLine("Thread  = {0}",Thread.CurrentThread.ManagedThreadId);
            Console.Read();
        }

        public static async Task Method1()
        {

            //Console.WriteLine("Thread  = {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Method 1 -----> Starts ");

            Console.WriteLine("Method 1 -----> Calling Async Method2");
            //Console.WriteLine("Thread  = {0}", Thread.CurrentThread.ManagedThreadId);
            Task<string>  method2OP =  Method2();

            Console.WriteLine("Method 1 -----> Running in async mode ");
            //Console.WriteLine("Thread  = {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine();
            Console.WriteLine("Method 1 -----> " + await method2OP); 

        }

        public  static async Task<string> Method2()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            Console.WriteLine("Method 2 -----> Starting Method 2");
            Console.WriteLine("Method 2 -----> delay started ");
            //Console.WriteLine("Thread  = {0}", Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(5000);
            //await Thread.Sleep(5000);
            //Console.WriteLine(Thread.CurrentThread.Name);
            Console.WriteLine("Method 2 -----> Delay Ends");
            Console.WriteLine("Method 2 ----->  returning from method 2");
            return "Method 2 -----> This is retun value from Method 2";
        }
    }
}
