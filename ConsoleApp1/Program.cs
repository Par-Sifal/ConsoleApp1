using System;

class Program
{
    static void Main()
    {
        // Запрашиваем имя пользователя
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();

        // Запрашиваем возраст пользователя
        Console.Write("Введите ваш возраст: ");
        int age;
        while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
        {
            Console.Write("Пожалуйста, введите корректный возраст: ");
        }

        // Выводим сообщение
        Console.WriteLine($"Привет, {name}! Тебе {age} лет.");
    }
}
