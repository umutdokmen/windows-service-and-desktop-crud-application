using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public Service1()
        {
            ConnectToDb();
        }
        SqlConnection conn;
        SqlCommand comm;

        SqlConnectionStringBuilder connectionStringBuilder;

        void ConnectToDb()
        {
            connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.DataSource = "LAPTOP-S1JS05JQ\\SQLEXPRESS";
            connectionStringBuilder.InitialCatalog = "ATS";
            connectionStringBuilder.Encrypt = true;
            connectionStringBuilder.TrustServerCertificate = true;
            connectionStringBuilder.ConnectTimeout = 500;
            connectionStringBuilder.AsynchronousProcessing = true;
            connectionStringBuilder.MultipleActiveResultSets = true;
            connectionStringBuilder.IntegratedSecurity = true;

            conn = new SqlConnection(connectionStringBuilder.ToString());
            comm = conn.CreateCommand();

        }


        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public int InsertOrder(Order o)
        {
            try
            {
                comm.CommandText = "INSERT INTO Orders VALUES(@OrderNo,@OrderDesc,@OrderDate,@OrderQuantity,@OrderCreationDate,@CreatedBy)";
                comm.Parameters.AddWithValue("OrderNo", o.OrderNo);
                comm.Parameters.AddWithValue("OrderDesc", o.OrderDesc);
                comm.Parameters.AddWithValue("OrderDate", o.OrderDate);
                comm.Parameters.AddWithValue("OrderQuantity", o.OrderQuantity);
                comm.Parameters.AddWithValue("OrderCreationDate", o.OrderCreationDate);
                comm.Parameters.AddWithValue("CreatedBy", o.CreatedBy);
                comm.CommandType = System.Data.CommandType.Text;
                conn.Open();
                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

    }
}
