using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataProvider
    {
        private static DataProvider instance;


      //   private string connectionSTR = @"Data Source=DESKTOP-5IDSEJ0\SQLEXPRESS;Initial Catalog=DuLieuChungKhoan;Integrated Security=True";
        private string connectionSTR = @"Data Source=LAMSAMCHAN;Initial Catalog=DuLieuChungKhoan;Integrated Security=True";
      //   private string connectionSTR = @"Data Source=PARAONG-YODANH\SQLEXPRESS;Initial Catalog=DuLieu_ChungKhoan;Integrated Security=True";


        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }

            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }
        public DataTable Executequery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandTimeout = 0;
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }

                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public int ExecuteNonquery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandTimeout = 0;
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }

                }

                data = command.ExecuteNonQuery();
                connection.Close();
            }

            return data;
        }

        public object ExecuteScala(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandTimeout = 0;
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }

                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
        public DataTable insertDB(DataTable dt)
        {
            
            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connectionSTR))
            {
                bulkCopy.DestinationTableName = dt.TableName;
                bulkCopy.BulkCopyTimeout = 0;

                foreach (var column in dt.Columns)
                {
                    bulkCopy.ColumnMappings.Add(column.ToString(), column.ToString());

                }
                
                bulkCopy.WriteToServer(dt);

            }
            return dt;
        }
    }
}
