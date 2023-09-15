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
        Console.WriteLine("Введите число: ");
        int number = int.Parse(Console.ReadLine());
        int len = (int)Math.Log10(number) + 1;
        Console.WriteLine(len);
        }
    }
}