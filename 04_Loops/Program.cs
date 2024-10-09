using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Loop

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine($"C# Education Camp {i}01");
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 30; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("How many times it will be written?");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 0; i < finishValue; i++)
            //{
            //    Console.WriteLine("!!! Turkiye !!!");
            //}

            #endregion

            #region Making Decision with For Loop

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0) Console.WriteLine(i);
            //}

            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for (int i = 0; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("-----");
            //Console.WriteLine(totalValue);

            //int count = 0;

            //for (int i = 1; i < 50; i++)
            //{
            //    if (i % 7 == 0) count++;
            //}

            //Console.WriteLine(count);

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    Console.WriteLine($"After {i} hours: {bacterium *= 2}");
            //}

            #endregion

            #region While Loop

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine($"Hello, I'm number {i}!");
            //    i++;
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i % 3 == 0) Console.WriteLine(i);
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i++;
            //}

            //Console.WriteLine(sum);

            #endregion

            #region Example

            // Find the sum of digits of a 3 digit number

            //Console.Write("Please enter a 3 digit number : ");
            //int number = int.Parse(Console.ReadLine());

            //int hundreds = number / 100;
            //int tens = number / 10 % 10;
            //int ones = number % 10;

            //int sum = hundreds + tens + ones;

            //Console.WriteLine(hundreds + " + " + tens + " + " + ones + " = " + sum);

            #endregion

            Console.Read();
        }
    }
}
