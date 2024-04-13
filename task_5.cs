using System;

class Program
{
    static void Main(string[] args)
    {
        int positiveCount = 0;
        int negativeCount = 0;
        int sum = 0;

        Console.WriteLine("Введіть числа.21");

        while (true)
        {
            Console.Write("Введіть число: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;
            }
            else if (number > 0)
            {
                positiveCount++;
            }
            else
            {
                negativeCount++;
            }

            sum += number;
        }

        Console.WriteLine($"Сума введених чисел: {sum}");
        Console.WriteLine($"Кількість додатних чисел: {positiveCount}");
        Console.WriteLine($"Кількість від'ємних чисел: {negativeCount}");

        Console.ReadKey();
    }
}
