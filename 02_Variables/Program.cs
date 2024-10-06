using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Variables

            //double number;
            //number = 3.45;
            //Console.WriteLine(number);

            //Console.WriteLine("*** Price List ***");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice;

            //applePrice = 0.75;
            //orangePrice = 1.25;
            //strawberryPrice = 1.58;

            //Console.OutputEncoding = Encoding.Unicode;

            //Console.WriteLine("---- Apple Unit Price : " + applePrice + " $/kg");
            //Console.WriteLine("---- Orange Unit Price : " + orangePrice + " $/kg");
            //Console.WriteLine("---- Strawberry Unit Price : " + strawberryPrice + " $/kg");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram;

            //appleGram = 1.234;
            //orangeGram = 2.987;
            //strawberryGram = 0.65;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;

            //Console.WriteLine("Product : Apple - " + "Unit Price : " + applePrice + " $/kg - KGram : " + appleGram + " kg - Total Apple Price : " + appleTotalPrice + " $");
            //Console.WriteLine("Product : Orange - " + "Unit Price : " + orangePrice + " $/kg - KGram : " + orangeGram + " kg - Total Apple Price : " + orangeTotalPrice + " $");
            //Console.WriteLine("Product : Strawberry - " + "Unit Price : " + strawberryPrice + " $/kg - KGram : " + strawberryGram + " kg - Total Apple Price : " + strawberryTotalPrice + " $");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Shopping Total Price : " + shoppingTotalPrice + " $");

            #endregion

            #region Char Variables

            //char symbol;
            //symbol = 'A';
            //Console.WriteLine(symbol);

            #endregion

            #region Data Entry From the Keyboard (string)

            //Console.WriteLine("*** CSharp Airlines Passenger Information ***");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerCity, passengerIdentityNo;

            //Console.Write("Passenger Name : ");
            //passengerName = Console.ReadLine();

            //Console.Write("Passenger SurName : ");
            //passengerSurname = Console.ReadLine().ToUpper();

            //Console.Write("Passenger Identity No : ");
            //passengerIdentityNo = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Passenger Identity No : " +passengerIdentityNo + " - Name Surname : " + passengerName + " " + passengerSurname);

            #endregion

            #region Data Entry From the Keyboard (int) - Converting

            //int shoesPrice, computerPrice, chairPrice;
            //shoesPrice = 60;
            //computerPrice = 550;
            //chairPrice = 200;

            //int shoesCount, computerCount, chairCount;

            //Console.Write("How many pairs of shoes did you buy? : ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("How many computers did you buy? : ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("How many chairs did you buy? : ");
            //chairCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice;

            //Console.WriteLine();
            //Console.WriteLine("Total Price : " + totalPrice + " $");

            #endregion

            #region Data Entry From the Keyboard (double)

            //double exam1, exam2, exam3, result;

            //Console.Write("1. exam score : ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2. exam score : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3. exam score : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Average Score : " + result);

            #endregion

            #region Data Entry From the Keyboard (char)

            //char gender;
            //Console.Write("Please choose a gender : ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Chosen gender : " + gender);

            #endregion

            Console.Read();
        }
    }
}
