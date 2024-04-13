using System;

class Program
{
    static void Main(string[] args)
    {
        double x = -2;
        double h = 0.2;

        Console.WriteLine("x\t|\ty");
        Console.WriteLine("-----------------------");

        while (x <= 5)
        {
            double y = Math.Sin(x) / Math.Log(x + 4);

            Console.WriteLine($"{x}\t|\t{y}");

            x += h;

            
        }
        Console.ReadKey();
    }
}
