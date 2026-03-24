using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var result = await CalculateAsync(5, 10);
        Console.WriteLine("Result: " + result);
    }

    static Task<int> CalculateAsync(int a, int b)
    {
        return Task.Run(() => {
            return a + b;
        });
    }
}
