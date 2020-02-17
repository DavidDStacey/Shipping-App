using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;

namespace Shipping
{

    /// <summary>
    /// static methods to connect to, disconnect from, store data to and retrieve data from database invoiceTable
    /// </summary>
    static class DataAdapter
    {
        static SqlConnection oConn = new SqlConnection("Data Source=stusql.ckwia8qkgyyj.us-east-1.rds.amazonaws.com,1433; " +
                                                        "Initial Catalog=CIS151-1; User Id=kt0857159; Password=0857159");

        public static void Connect()
        {
            try
            {
                oConn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Disconnect()
        {
            try
            {
                oConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Insert(string data)
        {
            string sqlIns = "INSERT INTO invoiceTable(Data) VALUES(@data)";

            try
            {
                Connect();

                SqlCommand cmdIns = new SqlCommand(sqlIns, oConn);
                cmdIns.Parameters.AddWithValue("@data", data);

                cmdIns.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        public static void ClearDB()
        {
            string sqlClear = "DELETE FROM invoiceTable;";

            try
            {
                Connect();

                SqlCommand cmdClear = new SqlCommand(sqlClear, oConn);

                cmdClear.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        public static ArrayList Get()
        {
            string sql = "SELECT * FROM invoiceTable";

            SqlCommand cmd = new SqlCommand(sql, oConn);

            try
            {
                Connect();

                ArrayList invoices = new ArrayList();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //while we are getting records from the DB
                    //we need to be deserializing them and add to an array
                    invoices.Add(Serializer.DeSerializeNow(reader["Data"].ToString()));
                }
                return invoices;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ArrayList invoices = new ArrayList();
                return invoices;
            }
            finally
            {
                Disconnect();
            }

        }
    }
}
