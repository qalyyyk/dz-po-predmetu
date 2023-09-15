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
        Console.WriteLine("Введите первое число: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int number2 = int.Parse(Console.ReadLine());
        int len = (number1 + number2);
        Console.WriteLine(len);
        }
    }
}