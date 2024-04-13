using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть ціле додатне число n:");
        int n = int.Parse(Console.ReadLine());

        int res = 1;

        for (int i = 2; i <= n; i += 2)
        {
            res *= i;
        }

        Console.WriteLine($"Добуток усіх парних чисел від 1 до {n} включно: {res}");
        Console.ReadKey();
    }
}
