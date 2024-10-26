using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("*** Menu Order Manage Panel ***");
            //Console.WriteLine();

            //Console.WriteLine("-------------------------------");

            #region Add Category

            //Console.Write("Enter the Category Name to Add : ");
            //string categoryName = Console.ReadLine();

            //SqlConnection sqlConnection = new SqlConnection("Data source = DESKTOP-FMRSALO\\SQLEXPRESS; initial catalog = EducationCampDb; integrated security = true");
            //sqlConnection.Open();

            //SqlCommand sqlCommand = new SqlCommand("insert into TBL_Category (CategoryName) values (@p1)", sqlConnection);

            //sqlCommand.Parameters.AddWithValue("@p1", categoryName);
            //sqlCommand.ExecuteNonQuery();

            //sqlConnection.Close();

            //Console.Write("Category Added Successfully!");

            #endregion

            #region Add Product

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Product Name : ");
            //productName = Console.ReadLine();
            //Console.Write("Product Price : ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection sqlConnection = new SqlConnection("Data source = DESKTOP-FMRSALO\\SQLEXPRESS; initial catalog = EducationCampDb; integrated security = true");
            //sqlConnection.Open();

            //SqlCommand sqlCommand = new SqlCommand("insert into TBL_Product (ProductName, ProductPrice, ProductStatus) values (@productName, @productPrice, @productStatus)", sqlConnection);
            //sqlCommand.Parameters.AddWithValue("@productName", productName);
            //sqlCommand.Parameters.AddWithValue("@productPrice", productPrice);
            //sqlCommand.Parameters.AddWithValue("@productStatus", true);

            //sqlCommand.ExecuteNonQuery();

            //sqlConnection.Close();

            //Console.WriteLine("Product Added Successfully");

            #endregion

            #region List Product

            //SqlConnection sqlConnection = new SqlConnection("Data Source = DESKTOP-FMRSALO\\SQLEXPRESS; initial catalog = EducationCampDb; integrated security = true");
            //sqlConnection.Open();

            //SqlCommand sqlCommand = new SqlCommand("Select * from TBL_Product", sqlConnection);
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            //DataTable dataTable = new DataTable();
            //sqlDataAdapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }

            //    Console.WriteLine();
            //}

            //sqlConnection.Close();

            #endregion

            #region Delete Product

            //Console.Write("Produc Id to Delete : ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection sqlConnection = new SqlConnection("Data Source = DESKTOP-FMRSALO\\SQLEXPRESS; initial catalog = EducationCampDb; integrated security = true");
            //sqlConnection.Open();

            //SqlCommand sqlCommand = new SqlCommand("Delete from TBL_Product where ProductId = @productId", sqlConnection);
            //sqlCommand.Parameters.AddWithValue("@productId", productId);
            //sqlCommand.ExecuteNonQuery();

            //sqlConnection.Close();

            //Console.WriteLine("Product deleted");

            #endregion

            #region Update Product

            //Console.Write("Product Id to update : ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Product Name to update : ");
            //string productName = Console.ReadLine();

            //Console.Write("Product Price to update : ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection sqlConnection = new SqlConnection("Data Source = DESKTOP-FMRSALO\\SQLEXPRESS; initial catalog = EducationCampDb; integrated security = true");
            //sqlConnection.Open();

            //SqlCommand sqlCommand = new SqlCommand("Update TBL_Product set ProductName = @productName, ProductPrice = @productPrice where ProductId = @productId", sqlConnection);
            //sqlCommand.Parameters.AddWithValue("@productName", productName);
            //sqlCommand.Parameters.AddWithValue("@productPrice", productPrice);
            //sqlCommand.Parameters.AddWithValue("@productId", productId);

            //sqlCommand.ExecuteNonQuery();

            //sqlConnection.Close();

            //Console.WriteLine("Updated Successfully!");

            #endregion

            Console.ReadLine();
        }
    }
}
