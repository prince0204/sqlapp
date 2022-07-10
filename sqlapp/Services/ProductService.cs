using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using sqlapp.Models;

namespace sqlapp.Services
{
    public class ProductService
    {
        public static string db_source = "sqldbserver11.database.windows.net";

        public static string db_user = "sqladmin";

        public static string db_password = "Pri774623nce$";

        public static string db_database = "appdb";

        private SqlConnection GetConnection()
        {
            var _builder = new SqlConnectionStringBuilder();
            _builder.DataSource = db_source;
            _builder.UserID = db_user;
            _builder.Password = db_password;
            _builder.InitialCatalog = db_database;
            return new SqlConnection(_builder.ConnectionString);
        }

        public List<Product> GetProducts()
        {
            SqlConnection conn = GetConnection();
            List<Product> _product_lst = new List<Product>();
            string statement = "SELECT ProductID, ProductName, Quantity FROM Products";
            conn.Open();
            SqlCommand cmd = new SqlCommand(statement,conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Product product = new Product()
                    {
                        ProductId = reader.GetInt32(0),
                        ProductName = reader.GetString(1),
                        Quantity = reader.GetInt32(2)
                    };

                    _product_lst.Add(product);
                }
            }
            conn.Close();
            return _product_lst;
        }


    }
}
