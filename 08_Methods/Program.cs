using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methods

            //void ListCustomers()
            //{
            //    Console.WriteLine("Army STARS");
            //    Console.WriteLine("Nikola TESLA");
            //    Console.WriteLine("Michael Jordan");
            //    Console.WriteLine("Chris NOLAN");
            //}

            //ListCustomers();
            //ListCustomers();
            //ListCustomers();

            //void Sum()
            //{
            //    int x = 2;
            //    int y = 9;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Void Methods (with String Parameters)

            //void WriteCustomer(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteCustomer("Army STARS");

            //void ShowCustomer(string name, string surname)
            //{
            //    Console.WriteLine("Customer : " + name + " " + surname);
            //}

            //ShowCustomer("Army", "STARS");
            //ShowCustomer("Michael", "JORDAN");

            #endregion

            #region Void Methods (with Int Parameters)

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 98, 7);

            #endregion

            #region Methods that return a value

            //string ShowCustomer()
            //{
            //    return "Army JORDAN";
            //}

            //Console.WriteLine(ShowCustomer());

            //string ShowStudent()
            //{
            //    string studentName = "Chris";
            //    string studentSurname = "Nolan";
            //    return studentName + " " + studentSurname;
            //}

            //Console.WriteLine(ShowStudent());

            #endregion

            #region Methods that return a value (with String Parameters)

            //string ShowCountry(string countryName, string capital, string flagColor)
            //{
            //    string info = "Country : " + countryName + " - Capital : " + capital + " - Color : " + flagColor;
            //    return info;
            //}

            //string x, y, z;

            //Console.Write("Enter the country name : ");
            //x = Console.ReadLine();

            //Console.Write("Enter the capital : ");
            //y = Console.ReadLine();

            //Console.Write("Enter the flag color : ");
            //z = Console.ReadLine();

            //Console.WriteLine(ShowCountry(x, y, z));

            //Console.WriteLine(ShowCountry("Turkiye", "Ankara", "Kirmizi - Beyaz"));

            #endregion

            #region Methods that return a value (with Int Parameters)

            //int Sum(int number1, int number2)
            //{
            //    return number1 + number2;
            //}

            //Console.WriteLine(Sum(45, 96));
            //Console.WriteLine(Sum(844, 153));
            //Console.WriteLine(Sum(1823, 12));

            #endregion

            #region Example

            //string CalculateExamResult(string studentName, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50) return studentName + " passed! " + $"Average score : {result}";
            //    else return studentName + " failed! " + $"Average score : {result}";
            //}

            //Console.WriteLine(CalculateExamResult("Army", 45, 50, 51));
            //Console.WriteLine(CalculateExamResult("Michael", 75, 50, 51));

            #endregion

            Console.Read();
        }
    }
}
