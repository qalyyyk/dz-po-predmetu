using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Введите первое число:");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int number2 = int.Parse(Console.ReadLine());
        if (number1 > number2) 
        {Console.WriteLine("Первая цифра больше");}
        else if (number1 < number2) 
        {Console.WriteLine("Вторая цифра больше");}
        else Console.WriteLine("Числа одинаковы нахуй");
        }
    }
}