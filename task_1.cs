using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть кількість разів:");
        int N = int.Parse(Console.ReadLine());

        string lastName = "Шевченко";

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(lastName);
        }
        Console.ReadKey();
    }
    
}
