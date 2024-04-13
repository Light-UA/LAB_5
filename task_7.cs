using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int[] password = new int[8];

        do
        {
            for (int i = 0; i < 8; i++)
            {
                // Генеруємо випадкову цифру від 1 до 6
                password[i] = random.Next(1, 7);
            }
        } while (!IsPasswordValid(password));

        Console.WriteLine("Згенерований пароль:");
        foreach (int digit in password)
        {
            Console.Write(digit);
        }

        Console.ReadKey();
    }

    static bool IsPasswordValid(int[] password)
    {
        // Перевіряємо, чи виконується умова суми трьох сусідніх цифр
        for (int i = 0; i < 6; i++)
        {
            if (password[i] + password[i + 1] + password[i + 2] != 8)
            {
                return false;
            }
        }

        return true;
    }
}
