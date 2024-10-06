using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Printing Commands

            //Console.Write("Hello World!!");
            //Console.WriteLine("Hi!");
            //Console.WriteLine("Can you see the difference?!");

            //Console.WriteLine("*** Menu ***");
            //Console.WriteLine();
            //Console.WriteLine("1-Soups");
            //Console.WriteLine("2-Main Courses");
            //Console.WriteLine("3-Desserts");
            //Console.WriteLine();
            //Console.WriteLine("*** Menu ***");

            #endregion

            #region String Variables

            //string name;
            //name = "Army";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerEmail, customerPhone, customerCountry;

            //customerName = "Army";
            //customerSurname = "Book";
            //customerEmail = "army@gmail.com";
            //customerPhone = "+90 500 111 22 33";
            //customerCountry = "Turkiye";

            //Console.WriteLine("*** Booking Details ***");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine("Customer : " + customerName + " " + customerSurname);
            //Console.WriteLine("Contact : " + customerPhone + " - " + customerEmail);
            //Console.WriteLine("From : " + customerCountry);
            //Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine();

            //customerName = "Chris";
            //customerSurname = "Nolan";
            //customerEmail = "cinema@outlook.com";
            //customerPhone = "+44 333 222 11 00";
            //customerCountry = "England";

            //Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine("Customer : " + customerName + " " + customerSurname);
            //Console.WriteLine("Contact : " + customerPhone + " - " + customerEmail);
            //Console.WriteLine("From : " + customerCountry);
            //Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine();

            #endregion

            #region Int Variables

            //int number = 333;
            //Console.WriteLine(number);

            int hamburgerPrice = 10;
            int pizzaPrice = 9;
            int cokePrice = 3;
            int lemonadePrice = 2;

            Console.OutputEncoding = Encoding.Unicode; //This was used for "€" symbol. (found on stackoverflow)

            Console.WriteLine("*** Restaurant Menu Prices ***");
            Console.WriteLine();
            Console.WriteLine("---- Hamburger : " + hamburgerPrice + " €");
            Console.WriteLine("---- Pizza : " + pizzaPrice + " €");
            Console.WriteLine("---- Coke : " + cokePrice + " €");
            Console.WriteLine("---- Lemonade : " + lemonadePrice + " €");
            Console.WriteLine();
            Console.WriteLine("*** Restaurant Menu Prices ***");

            Console.WriteLine();

            int hamburgerCount, pizzaCount, cokeCount, lemonadeCount;

            int totalHamburgerPrice, totalPizzaPrice, totalCokePrice, totalLemonadePrice;

            hamburgerCount = 3;
            pizzaCount = 2;
            cokeCount = 5;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            totalPizzaPrice = pizzaPrice * pizzaCount;
            totalCokePrice = cokePrice * cokeCount;
            totalLemonadePrice = lemonadePrice * lemonadeCount;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Hamburger Total : " + totalHamburgerPrice + " €");
            Console.WriteLine("Pizza Total : " + totalPizzaPrice + " €");
            Console.WriteLine("Coke Total : " + totalCokePrice + " €");
            Console.WriteLine("Lemonade Total : " + totalLemonadePrice + " €");

            Console.WriteLine();

            int totalPaymentPrice = totalHamburgerPrice + totalPizzaPrice + totalCokePrice + totalLemonadePrice;
            
            Console.WriteLine("Total Payment Price : " + totalPaymentPrice + " €");
            
            #endregion

            Console.Read();
        }
    }
}
