using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть номер дня (від 1 до 365):");
        int N = int.Parse(Console.ReadLine());

        bool leapYear = DateTime.IsLeapYear(2024);

        int[] daysInMonth = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        int totalDays = 0;
        int month = 0;
        int day = 0;

        for (int i = 0; i < daysInMonth.Length; i++)
        {
            totalDays += daysInMonth[i];
            if (N <= totalDays)
            {
                month = i + 1;
                day = N - (totalDays - daysInMonth[i]);
                break;
            }
        }

        Console.WriteLine($"Число: {day}, Місяць: {month}");

        Console.ReadKey();
    }
}
