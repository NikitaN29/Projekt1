using System;


namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину пароля:");
            int length = int.Parse(Console.ReadLine());

            string password = GeneratePassword(length);

            Console.WriteLine("Сгенерированный пароль: " + password);
        }

        static string GeneratePassword(int length)
        {
            string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            Random random = new Random();
            char[] password = new char[length];

            for (int i = 0; i < length; i++)
            {
                password[i] = allowedChars[random.Next(allowedChars.Length)];
            }

            return new string(password);
        }
    }
}