using System;

namespace _13_12_2022
{
    internal class Program
    {
        static void Main()
        {
            string input;
            int output = 0;
            bool can_be_converted = true;
            Console.Write("Введите строку из цифр: ");
            input = Console.ReadLine();
            foreach (char c in input)
            {
                output *= 10;
                if (output < 0)
                {
                    Console.WriteLine("Выход за границы диапазона int");
                    can_be_converted = false;
                    break;
                }
                if (char.IsDigit(c)) output += Convert.ToInt32(char.GetNumericValue(c));
                else
                {
                    Console.WriteLine("Введена не цифра");
                    can_be_converted = false;
                    break;
                }
            }
            if (can_be_converted) Console.WriteLine($"Введено число {output}");
        }
    }
}