using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////Ado.net

            //Console.WriteLine("*** C# Data Based Category-Product Information System ***");
            //Console.WriteLine();

            //string tableNumber;

            //Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine("1-Categories");
            //Console.WriteLine("2-Products");
            //Console.WriteLine("3-Orders");
            //Console.WriteLine("4-Log Out");
            //Console.Write("Please enter the table number you want to see : ");
            //tableNumber = Console.ReadLine();
            //Console.WriteLine("---------------------------------------------------");

            //SqlConnection sqlConnection = new SqlConnection("Data Source = DESKTOP-FMRSALO\\SQLEXPRESS; initial catalog = EducationCampDb; integrated security = true");
            //sqlConnection.Open();

            //SqlCommand sqlCommand = new SqlCommand("Select * From TBL_Category", sqlConnection);
            //SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);
            //DataTable dataTable = new DataTable();
            //sqlAdapter.Fill(dataTable);

            //sqlConnection.Close();

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString());
            //    }

            //    Console.WriteLine();
            //}

            //Console.ReadLine();
        }
    }
}
