using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTakip
{
    class SqlHelper
    {
        private string ConnectionString { get; set; }
        private SqlConnection Connection { get; set; }

        public SqlHelper()
        {
            ConnectionString = "Server=Wissen\\SQLEXPRESS; Database=StockManagement; User ID= Section1; Integrated Security=true;";
            Connection = new SqlConnection(ConnectionString);
        }
        public int ExecuteCommand(string querry)
        {
            SqlCommand command = new SqlCommand(querry, Connection);
            Connection.Open();
            int r = command.ExecuteNonQuery();
            Connection.Close();
            return r;
        }

        public void ExecuteProc(string procName, int? Id = null)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procName;
            if (Id.HasValue)
                command.Parameters.AddWithValue("ID", Id.Value);
            command.Connection = Connection;
            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();
        }
        public void ExecuteProc(string procName,params SqlParameter[] ps)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procName;
            command.Parameters.AddRange(ps); 
            command.Connection = Connection;
            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();
        }
        public DataTable GetTable(string querry)
        {
            SqlDataAdapter sda = new SqlDataAdapter(querry, ConnectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
