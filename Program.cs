using System;

namespace testSH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Здравствуйте {name}");
        }
    }
}
