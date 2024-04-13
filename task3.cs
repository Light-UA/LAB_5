using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть дійсне число x:");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть ціле додатне число k:");
        int k = int.Parse(Console.ReadLine());

        double res = 1;

        for (int i = 0; i < k; i++)
        {
            res *= x;
        }

        Console.WriteLine($"{x}^{k}={res}");
        Console.ReadKey();
    }
}
