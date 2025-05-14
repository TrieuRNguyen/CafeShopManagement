using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShopManagementSystem.frmCashierMainFromforder
{
    public class CashierOrderFromProdData
    {
        public int ID { set; get; } // 0
        public string ProductID { set; get; } // 1
        public string ProductName { set; get; } // 2
        public string Type { set; get; } // 3
        public string Stock { set; get; } // 4
        public string Price { set; get; } // 5
        public string Status { set; get; } // 6

        SqlConnection connect = new SqlConnection("Data Source=.;Initial Catalog=CafeShopDB;Integrated Security=True;Encrypt=False");

        public List<CashierOrderFromProdData> availableProductsData()
        {
            List<CashierOrderFromProdData> listData = new List<CashierOrderFromProdData>();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM products WHERE prod_status = @stats AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@stats", "Available");

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            CashierOrderFromProdData apd = new CashierOrderFromProdData();

                            apd.ID = (int)reader["id"];
                            apd.ProductID = reader["prod_id"].ToString();
                            apd.ProductName = reader["prod_name"].ToString();
                            apd.Type = reader["prod_type"].ToString();
                            apd.Stock = reader["prod_stock"].ToString();
                            apd.Price = reader["prod_price"].ToString();
                            apd.Status = reader["prod_status"].ToString();

                            listData.Add(apd);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed Connection: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        }
    }
}
