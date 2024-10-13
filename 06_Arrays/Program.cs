using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basic Array Examples

            //string[] colors = new string[4];
            //colors[0] = "Red";
            //colors[1] = "Yellow";
            //colors[2] = "White";
            //colors[3] = "Blue";

            //Console.WriteLine(colors[1]);

            //string[] cities = new string[5];
            //cities[0] = "Istanbul";
            //cities[1] = "London";
            //cities[2] = "Paris";
            //cities[3] = "Milan";
            //cities[4] = "Berlin";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 13;
            //numbers[1] = 562;
            //numbers[2] = 7;
            //numbers[3] = 1289;
            //numbers[7] = 400;

            //Console.WriteLine(numbers[6]);

            //string[] cities = { "Chicago", "Washington", "Los Angeles", "New York", "Dallas" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region Display All Members of an Array

            //string[] colors = { "Yellow", "Red", "White", "Blue", "Green", "Orange", "Pink" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 3, 89, 456, 13, 364, 776, 6345, 9, 5047 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0) Console.WriteLine(numbers[i]);
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '&', '?' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //string[] people = { "Army", "Nolan", "Taylor", "Jordan", "Nietzsche", "Merkel" };

            //Console.WriteLine(people.Length);

            //int[] myNumbers = { 3, 896, 45, 61, 7531, 74, 61, 4, 198, 652 };

            //int maxNumber = myNumbers[0];

            //for (int i = 1; i < myNumbers.Length; i++)
            //{
            //    if (myNumbers[i] > maxNumber) maxNumber = myNumbers[i];
            //}

            //Console.WriteLine($"The max number is = {maxNumber}");

            //int[] numbers = { 78, 26, 395, 256, 1203, 4, 196, 15 };
            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 78, 26, 395, 256, 1203, 4, 196, 15 };
            //Array.Sort(numbers);

            //Console.WriteLine(numbers[0]);

            //int[] numbers = { 78, 26, 395, 256, 1203, 4, 196, 15 };
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 78, 26, 395, 256, 1203, 4, 196, 15 };
            //Array.Sort(numbers);
            //Array.Reverse(numbers);

            //Console.WriteLine(numbers[0]);

            #endregion

            #region Array Methods

            //string[] people = { "Pele", "Maradona", "Messi", "Ronaldo" };
            //int index = Array.IndexOf(people, "Maradona");
            //Console.WriteLine(index);

            //int[] numbers = { 6, 75, 19, 753, 159, 456 };
            //Console.WriteLine($"Max value = {numbers.Max()} , Min value = {numbers.Min()}");

            #endregion

            #region Get Value from Client

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Enter {i + 1}. city : ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("------------------------");

            //for (int i = 0; i < cities.Length; i++) Console.WriteLine(cities[i]);

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);

            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 458, 1009, 20 };

            //Console.WriteLine("Even Numbers :");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0) Console.WriteLine(numbers[i]);
            //}

            //Console.WriteLine("-----------------");

            //Console.WriteLine("Odd Numbers :");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1) Console.WriteLine(numbers[i]);
            //}

            #endregion

            Console.Read();

        }
    }
}
