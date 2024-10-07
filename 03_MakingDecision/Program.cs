using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Please enter the password : ");
            //string password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Accepted");
            //}
            //else
            //{
            //    Console.WriteLine("Denied");
            //}

            //string capitalCity, country;

            //Console.Write("Enter the country : ");
            //country = Console.ReadLine();

            //Console.Write("Enter the capital city : ");
            //capitalCity = Console.ReadLine();

            //if (capitalCity == "london" & country == "england")
            //{
            //    Console.WriteLine("Information is confirmed");
            //}
            //else Console.WriteLine("Incorrect information");

            //Console.Write("Please enter the number : ");
            //int number = int.Parse(Console.ReadLine());

            //if (number == 3)
            //{
            //    Console.WriteLine("Correct! :)");
            //}
            //else Console.WriteLine("False :(");

            //int exam1, exam2, exam3, average;
            //string result="Error!";

            //Console.Write("Exam 1 : ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Exam 2 : ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Exam 3 : ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Average : " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Failed";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Average";
            //}
            //if(average > 70 & average <= 85)
            //{
            //    result = "Good";
            //}
            //if (average > 85 & average <= 100)
            //{
            //    result = "Very Good";
            //}

            //Console.WriteLine(result);

            //string city;

            //Console.Write("Please enter the city : ");
            //city = Console.ReadLine();

            //if (city == "london" | city == "manchester" | city == "liverpool")
            //{
            //    Console.Write("City info is existing");
            //}
            //else Console.WriteLine("City info is NOT existing");

            //Console.Write("Please enter your username : ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Access denied!");
            //}
            //else Console.WriteLine("Welcome!!");

            #endregion

            #region Modulus Operator

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Please enter 1. number : ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Please enter 2. number : ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("The remainder of the division of 1 number to 2 number : " + result);

            //Console.Write("Enter the number : ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("The number is even");
            //}
            //else Console.WriteLine("The number is odd");

            #endregion

            #region Making Decision with Char Variables

            //Console.Write("Please enter your team symbol : ");

            //char c = char.Parse(Console.ReadLine().ToLower());

            //if (c == 'l')
            //{
            //    Console.WriteLine("You are fan of Liverpool");
            //}
            //if (c == 'a')
            //{
            //    Console.WriteLine("You are fan of Arsenal");
            //}

            //char c = char.Parse(Console.ReadLine());

            //if (c == 'l' | c == 'L')
            //{
            //    Console.WriteLine("You are fan of Liverpool");
            //}
            //if (c == 'A' | c == 'a')
            //{
            //    Console.WriteLine("You are fan of Arsenal");
            //}

            #endregion

            #region Example Project

            //Console.WriteLine("*** CSharp Camp Restaurant ***");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("1-Main Courses");
            //Console.WriteLine("2-Desserts");
            //Console.WriteLine("3-Drinks");
            //Console.WriteLine("------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Please choose from the list above : ");
            //menuItem = Console.ReadLine();

            //if(menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----- Main Courses -----");
            //    Console.WriteLine("* Chicken with Curry Sauce");
            //    Console.WriteLine("* Baked Pasta");
            //    Console.WriteLine("* Meatball Potatoes");
            //    Console.WriteLine("----- Main Courses -----");
            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----- Desserts -----");
            //    Console.WriteLine("* Chewy Brownie");
            //    Console.WriteLine("* Pavlova");
            //    Console.WriteLine("* Tiramisu");
            //    Console.WriteLine("----- Desserts -----");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----- Drinks -----");
            //    Console.WriteLine("* Lemonade");
            //    Console.WriteLine("* Frozen");
            //    Console.WriteLine("* Coffee");
            //    Console.WriteLine("----- Drinks -----");
            //    Console.WriteLine();
            //}

            #endregion

            #region Switch Case

            //Console.Write("Please enter the day : ");
            //int dayNumber = int.Parse(Console.ReadLine());

            //switch (dayNumber)
            //{
            //    case 1: Console.WriteLine("Monday"); break;
            //    case 2: Console.WriteLine("Tuesday"); break;
            //    case 3: Console.WriteLine("Wednesday"); break;
            //    case 4: Console.WriteLine("Thursday"); break;
            //    case 5: Console.WriteLine("Friday"); break;
            //    case 6: Console.WriteLine("Saturday"); break;
            //    case 7: Console.WriteLine("Sunday"); break;
            //    default: Console.WriteLine("Error!!"); break;
            //}

            #endregion

            #region Switch Case Calculator

            //int number1, number2, result;
            //char symbol;

            //Console.Write("Enter 1. number : ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter 2. number : ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the operation : ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Addition : " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Subtraction : " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Multiplication : " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Division : " + result);
            //        break;
            //    default:
            //        Console.WriteLine("Error!!");
            //        break;
            //}

            #endregion

            Console.Read();
        }
    }
}
