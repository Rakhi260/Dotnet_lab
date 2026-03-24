using System;

delegate int Operation(int a, int b);

class Calculator
{
    static void Main()
    {
        Operation add = (x, y) => x + y;
        Operation sub = (x, y) => x - y;

        Console.WriteLine("Add: " + add(10, 5));
        Console.WriteLine("Subtract: " + sub(10, 5));
    }
}
