﻿class Program
{
    static Random random => new Random();
    static double GetRandomDouble(int max) => max * random.NextDouble();

    static void Printvalue(double d) => Console.WriteLine($"The value is {d:0.0000}");

    static void Main(string[] args)
    {
        var value = Program.GetRandomDouble(100);
        Program.Printvalue(value);
    }
}