using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите целое число: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number % 2 == 0)
                    Console.WriteLine("Четное");
                else
                    Console.WriteLine("Нечетное");
            }
            else
            {
                Console.WriteLine("Ошибка ввода.");
            }
        }
    }
}