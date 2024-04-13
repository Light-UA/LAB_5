using System;

class Program
{
    static void Main(string[] args)
    {
        int maxEmployees = 0;

        // Цикли для генерації паролей та підрахунку максимальної кількості співробітників
        for (int d1 = 1; d1 <= 6; d1++)
        {
            for (int d2 = 1; d2 <= 6; d2++)
            {
                for (int d3 = 1; d3 <= 6; d3++)
                {
                    for (int d4 = 1; d4 <= 6; d4++)
                    {
                        for (int d5 = 1; d5 <= 6; d5++)
                        {
                            for (int d6 = 1; d6 <= 6; d6++)
                            {
                                for (int d7 = 1; d7 <= 6; d7++)
                                {
                                    for (int d8 = 1; d8 <= 6; d8++)
                                    {
                                        int sum = d1 + d2 + d3 + d4 + d5 + d6 + d7 + d8;
                                        if (sum % 8 == 0)
                                        {
                                            maxEmployees++;
                                            Console.WriteLine($"{d1}{d2}{d3}{d4}{d5}{d6}{d7}{d8}");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        // Виведення максимальної кількості співробітників
        Console.WriteLine($"Максимальна кількість співробітників: {maxEmployees}");

        // Завершення програми
        Console.ReadKey();
    }
}
