using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
public class Printer
{
    private object lockToken = new object();
    public void PrintNumbers()
    {
        lock (lockToken)
        {
            //Display Thread info
            Console.WriteLine("Thread-> {0} started @{1} and executing PrintNumbers() method", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToLongTimeString());


            Console.Write("Your numbers: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}, ", i);
                Thread.Sleep(1000);
            }

        }
        Console.WriteLine();
    }

}