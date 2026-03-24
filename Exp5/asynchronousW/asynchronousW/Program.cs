using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Start");
        await DoWorkAsync();
        Console.WriteLine("End");
    }

    static async Task DoWorkAsync()
    {
        Console.WriteLine("Working...");
        await Task.Delay(3000); 
        Console.WriteLine("Work done!");
    }
}
