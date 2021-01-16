using System;

namespace PassGen
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Генератор паролей";

            Console.Write("Количество паролей");
            byte passwords = Convert.ToByte(Console.ReadLine());
        }
    }
}
