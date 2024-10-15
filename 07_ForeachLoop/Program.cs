using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach

            //string[] cities = new string[5];

            //cities[0] = "Izmir";
            //cities[1] = "Lyon";
            //cities[2] = "Manchester";
            //cities[3] = "Munich";
            //cities[4] = "Venice";

            //string[] cities = new string[] { "Izmir", "Lyon", "Manchester", "Munich", "Venice" };

            //string[] cities = { "Izmir", "Lyon", "Manchester", "Munich", "Venice" };

            //foreach (string item in cities)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] numbers = { 9, 5, 45, 852, 12, 6, 1526, 785 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 9, 5, 45, 852, 12, 6, 1526, 785 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0) Console.WriteLine(number);
            //}

            //int[] numbers = { 9, 5, 45, 852, 12, 6, 1526, 785 };

            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number;
            //}

            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 13
            //};

            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //string hello = "Hello World!!";

            //foreach (char item in hello)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Average Exam Score Practice

            //Console.WriteLine("*** C# Education Camp Exam Practice ***");
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("--------------------");
            //Console.Write("Student Count ? : ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("----------");

            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. Student Name ? : ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"   {j + 1}. Exam Score of {studentNames[i]} ? : ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value;
            //    }

            //    Console.WriteLine();

            //    studentExamAvg[i] = totalExamResult / 3;
            //}

            //Console.WriteLine("-----");

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} 's average score : {studentExamAvg[i]}");
            //    if (studentExamAvg[i] >= 50) Console.WriteLine($"{studentNames[i]} passed the course");
            //    else Console.WriteLine($"{studentNames[i]} failed the course");
            //    Console.WriteLine();
            //}

            //Console.WriteLine("-----");

            #endregion

            Console.Read();
        }
    }
}
