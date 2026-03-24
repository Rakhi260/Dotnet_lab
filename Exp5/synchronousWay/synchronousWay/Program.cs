using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Start");
        DoWork();
        Console.WriteLine("End");
    }

    static void DoWork()
    {
        Console.WriteLine("Working...");
        Thread.Sleep(3000); // blocks for 3 seconds
        Console.WriteLine("Work done!");
    }
}
